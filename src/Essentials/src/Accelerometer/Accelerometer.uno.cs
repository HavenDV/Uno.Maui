using Windows.Devices.Sensors;
using Uno;
using WindowsAccelerometer = Windows.Devices.Sensors.Accelerometer;

namespace Microsoft.Maui.Devices.Sensors
{
	partial class AccelerometerImplementation
	{
		// keep around a reference so we can stop this same instance
		WindowsAccelerometer sensor;

		internal static WindowsAccelerometer DefaultSensor =>
			WindowsAccelerometer.GetDefault();

		public bool IsSupported =>
			DefaultSensor != null;

		[NotImplemented(new string[] {"__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__"})]
		void PlatformStart(SensorSpeed sensorSpeed)
		{
			sensor = DefaultSensor;

			var interval = sensorSpeed.ToPlatform();
			sensor.ReportInterval = sensor.MinimumReportInterval >= interval ? sensor.MinimumReportInterval : interval;

			sensor.ReadingChanged += DataUpdated;
		}

		void DataUpdated(object sender, AccelerometerReadingChangedEventArgs e)
		{
			var reading = e.Reading;
			var data = new AccelerometerData(reading.AccelerationX * -1, reading.AccelerationY * -1, reading.AccelerationZ * -1);
			OnChanged(data);
		}

		void PlatformStop()
		{
			sensor.ReadingChanged -= DataUpdated;
			sensor.ReportInterval = 0;
		}
	}
}
