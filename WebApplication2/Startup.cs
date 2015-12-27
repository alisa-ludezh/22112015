using System;
using System.Collections.Generic;

namespace WebApplication2
{
    public partial class Day
    {
        private DateTime date;
        private DayTimeType DayType;
        public struct DayTimeType
        {
            public string Name;
            public string FullName;
            public byte Code;
            public string ColorStr;
        };
        public static List<DayTimeType> TypesDictionary
        {
            get
            {
                List<DayTimeType> TypesDictionary = new List<DayTimeType>()
                {
                    new DayTimeType { Name = "K",  ColorStr = "913D88",  FullName = "Служебная командировка", Code = 6},
                    new DayTimeType { Name = "ПК", ColorStr = "9B59B6", FullName = "Повышение квалификации с отрывом от работы", Code = 7},
                    new DayTimeType { Name = "Я",  ColorStr = "acf3a7",  FullName = "Явка", Code = 1},
                    new DayTimeType { Name = "В",  ColorStr = "C8F7C5",  FullName = "Выходной", Code = 80},
                    new DayTimeType { Name = "Б",  ColorStr = "2574A9",  FullName = "Временная нетрудоспособность с назначением пособия согласно законодательству", Code = 19},
                    new DayTimeType { Name = "НН", ColorStr = "D91E18", FullName = "Неявки по невыясненным причинам (до выяснения обстоятельств)", Code = 30 },
                    new DayTimeType { Name = "ОТ", ColorStr = "913D88", FullName = "Ежегодный основной оплачиваемый отпуск", Code = 9},
                    new DayTimeType { Name = "ДО", ColorStr = "F4D03F", FullName = "Отпуск без сохранения заработной платы, предоставляемый работнику по разрешению работодателя", Code = 16},
                    new DayTimeType { Name = "ОЗ", ColorStr = "2574A9", FullName = "Отпуск без сохранения заработной платы в случаях, предусмотренных законодательством", Code = 17},
                    new DayTimeType { Name = "ОЧ", ColorStr = "D91E18", FullName = "Отпуск по уходу за ребенком до достижения им возраста полутора лет", Code = 104},
                    new DayTimeType { Name = "ОЖ", ColorStr = "F9BF3B", FullName = "Отпуск по уходу за ребенком до достижения им возраста трех лет", Code = 15},
                    new DayTimeType { Name = "Р",  ColorStr = "2574A9",  FullName = "Отпуск по беременности и родам (отпуск в связи с усыновлением новорожденного ребенка)", Code = 14},
                    new DayTimeType { Name = "ПМ", ColorStr = "D91E18", FullName = "Повышение квалификации с отрывом от работы в другой местности", Code = 8},
                    new DayTimeType { Name = "РВ", ColorStr = "913D88", FullName = "Продолжительность работы в выходные и нерабочие, праздничные дни", Code = 3},
                    new DayTimeType { Name = "Д",  ColorStr = "2574A9",  FullName = "Дорога", Code = 39},
                    new DayTimeType { Name = "ОД", ColorStr = "D91E18", FullName = "Ежегодный дополнительный оплачиваемый отпуск", Code = 10}
                };
                return TypesDictionary;
            }
        }

        public Person Person
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        public Day(DateTime day, Person person, DayTimeType type)
        {
            this.date = day;
            this.DayType = type;
            this.Person = person;
        }
    }
}
