#nullable disable
//
// Tweener.cs
//
// Author:
//       Jason Smith <jason.smith@xamarin.com>
//
// Copyright (c) 2012 Microsoft.Maui.Controls Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using Microsoft.Maui.Animations;
using Microsoft.Maui.Controls.Internals;

namespace Microsoft.Maui.Controls
{
	internal class TweenerAnimation : Animation
	{
		readonly Func<long, bool> _step;

		public TweenerAnimation(Func<long, bool> step)
		{
			_step = step;
		}
		protected override void OnTick(double millisecondsSinceLastUpdate)
		{
			var running = _step.Invoke((long)millisecondsSinceLastUpdate);
			HasFinished = !running;
		}

	}

	internal class Tweener
	{
		IAnimationManager animationManager;
		long _lastMilliseconds;

		int _timer;
		long _frames;

		public Tweener(uint length, IAnimationManager animationManager)
		{
			Value = 0.0f;
			Length = length;
			this.animationManager = animationManager;
			Rate = 1;
			Loop = false;
		}

		public Tweener(uint length, uint rate, IAnimationManager animationManager)
		{
			Value = 0.0f;
			Length = length;
			Rate = rate;
			this.animationManager = animationManager;
			Loop = false;
		}

		public AnimatableKey Handle { get; set; }

		public uint Length { get; }

		public uint Rate { get; }

		public bool Loop { get; set; }

		public double Value { get; private set; }

		public event EventHandler Finished;

		public void Pause()
		{
			if (_timer != 0)
			{
				animationManager.Remove(_timer);
				_timer = 0;
			}
		}

		public void Start()
		{
			Pause();

			_lastMilliseconds = 0;
			_frames = 0;

			if (!animationManager.Ticker.SystemEnabled)
			{
				FinishImmediately();
				return;
			}

			_timer = animationManager.Insert(step =>
			{
				if (step == long.MaxValue)
				{
					// We're being forced to finish
					Value = 1.0;
				}
				else
				{
					long ms = step + _lastMilliseconds;

					Value = Math.Min(1.0f, ms / (double)Length);

					_lastMilliseconds = ms;
				}

				long wantedFrames = (_lastMilliseconds / Rate) + 1;
				if (wantedFrames > _frames || Value >= 1.0f)
				{
					ValueUpdated?.Invoke(this, EventArgs.Empty);
				}
				_frames = wantedFrames;

				if (Value >= 1.0f)
				{
					if (Loop)
					{
						_lastMilliseconds = 0;
						Value = 0.0f;
						return true;
					}

					Finished?.Invoke(this, EventArgs.Empty);
					Value = 0.0f;
					_timer = 0;
					return false;
				}
				return true;
			});
			if (!animationManager.Ticker.IsRunning)
				animationManager.Ticker.Start();
		}

		void FinishImmediately()
		{
			Value = 1.0f;
			ValueUpdated?.Invoke(this, EventArgs.Empty);
			Finished?.Invoke(this, EventArgs.Empty);
			Value = 0.0f;
			_timer = 0;
		}

		public void Stop()
		{
			Pause();
			Value = 1.0f;
			Finished?.Invoke(this, EventArgs.Empty);
			Value = 0.0f;
		}

		public event EventHandler ValueUpdated;

		~Tweener()
		{
			if (_timer != 0)
			{
				try
				{
					animationManager.Remove(_timer);
				}
				catch (InvalidOperationException)
				{
				}
			}
			_timer = 0;
		}
	}
}