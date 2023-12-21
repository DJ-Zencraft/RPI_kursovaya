namespace RPI_kursovaya
{
    /// <summary>
    /// Класс констант
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Имена таблиц
        /// </summary>
        public static class TableNames
        {
            /// <summary>
            /// Отделы
            /// </summary>
            public const string StorageTableName = "Storage";


            public const string TrucksTableName = "Trucks";
            /// <summary>
            /// Сотрудники
            /// </summary>
            public const string CategoriesTableName = "Categories";
            /// <summary>
            /// Персональные данные
            /// </summary>
            public const string ShipmentsTableName = "Shipments";
            /// <summary>
            /// Рабочие данные
            /// </summary>
            public const string CharacteristicsTableName = "Characteristics";
        }
        public static class FieldsNames
        {
            public const string Id = "Id";
            public static class StorageTable
            {
                public const string Address = "Address";
            }
            public static class TrucksTable
            {
                public const string StoragId = "StoragId";
                public const string CarNum = "CarNum";
                public const string Status = "Status";
                public const string Model = "Model";
                public const string MaxLoad = "MaxLoad";
            }
            public static class CategoriesTable
            {
                public const string StorageId = "StorageId";
                public const string CatName = "CatName";
                
            }
            public static class ShipmentsTable
            {
                public const string CatId = "CatId";
                public const string Name = "Name";
                public const string Count = "Count";
            }
            public static class CharacteristicsTable
            {
                public const string ShipId = "ShipId";
                public const string Mass = "Mass";
                public const string Size = "Size";
                public const string Material = "Material";
                public const string Colour = "Colour";
            }
        }
    }
}

