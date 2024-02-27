//using pa.imc.logik.Properties;

//namespace pa.imc.logik.UniqueId
//{
//    public static class UniqueIdGenerator
//    {
//        // Eigenschaften für die IDs
//        public static int NextRaumId
//        {
//            get { return MySettings.Default.RaumId; }
//            set
//            {
//                MySettings.Default.RaumId = value;
//                MySettings.Default.Save();
//            }
//        }

//        public static int NextEquipId
//        {
//            get { return Properties.Settings.Default.EquipId; }
//            set
//            {
//                Properties.Settings.Default.EquipId = value;
//                Properties.Settings.Default.Save();
//            }
//        }

//        // Methoden zum Abrufen und Erhöhen der IDs
//        public static int GetNextRaumId()
//        {
//            int nextId = NextRaumId;
//            NextRaumId++;
//            return nextId;
//        }

//        public static int GetNextEquipId()
//        {
//            int nextId = NextEquipId;
//            NextEquipId++;
//            return nextId;
//        }
//    }
//}
