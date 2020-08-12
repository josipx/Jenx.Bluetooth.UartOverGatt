using System;

namespace Jenx.Bluetooth.UartOverGatt.Client
{
    public class GattIdentifiers
    {
        public static Guid UartGattServiceId = Guid.Parse("0000FFF0-0000-1000-8000-00805f9b34fb");
        public static Guid UartGattCharacteristicReceiveId = Guid.Parse("0000FFF1-0000-1000-8000-00805f9b34fb");
        public static Guid UartGattCharacteristicSendId = Guid.Parse("0000FFF2-0000-1000-8000-00805f9b34fb");
        public static Guid SpecialNotificationDescriptorId = Guid.Parse("00002902-0000-1000-8000-00805f9b34fb");
    }
}