namespace csharp_8._4
{
    public struct Abonent
    {
       /// <summary>
       /// Переменная структуры адреса
       /// </summary>
        public Adress adress { get; set; }

        /// <summary>
        /// Переменная структуры телефонов
        /// </summary>
        public Phones phones { get; set; }
        

        /// <summary>
        /// Абонент
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Street"></param>
        /// <param name="HouseNumber"></param>
        /// <param name="ApartmentNumber"></param>
        /// <param name="MobilePhone"></param>
        /// <param name="HousePhone"></param>
        public Abonent(Adress adress, Phones phones)
        {
            this.adress = adress;
            this.phones = phones;
        }

        public struct Adress
        {
            /// <summary>
            /// Имя абонента
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Улица
            /// </summary>
            public string Street { get; set; }

            /// <summary>
            /// Номер дома
            /// </summary>
            public string HouseNumber { get; set; }

            /// <summary>
            /// Номер квартиры
            /// </summary>
            public string ApartmentNumber { get; set; }


            /// <summary>
            /// Адрес
            /// </summary>
            /// <param name="Name"></param>
            /// <param name="Street"></param>
            /// <param name="HouseNumber"></param>
            /// <param name="ApartmentNumber"></param>
            public Adress(string Name, string Street, string HouseNumber, string ApartmentNumber)
            {
                this.Name = Name;
                this.Street = Street;
                this.HouseNumber = HouseNumber;
                this.ApartmentNumber = ApartmentNumber;
            }
        }

        public struct Phones
        {

            /// <summary>
            /// Мобильный телефон
            /// </summary>
            public string MobilePhone { get; set; }

            /// <summary>
            /// Домашний телефон
            /// </summary>
            public string HousePhone { get; set; }


            /// <summary>
            /// Телефоны
            /// </summary>
            /// <param name="MobilePhone"></param>
            /// <param name="HousePhone"></param>
            public Phones(string MobilePhone, string HousePhone)
            {
                this.MobilePhone = MobilePhone;
                this.HousePhone = HousePhone;
            }
        }
    }

   
}
