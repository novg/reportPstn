﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportPstn
{
    class LimitsInitializer
    {
        internal static string[] Caption()
        {
            string[] caption = { "Телефон", "Сумма", "Лимит в руб.", "Перерасход", "Экономия" };
            return caption;
        }

        internal static string[,] ManagementSaz()
        {
            string[,] array =
            {
                {"Приемная управляющего директора ОАО \"Саяногорский Алюминиевый Завод\"", "531200000", "73680"},
                {"Приемная управляющего директора ОАО \"Саяногорский Алюминиевый Завод\"", "531200000", "77431"},
                {"Приемная управляющего директора ОАО \"Саяногорский Алюминиевый Завод\"", "531200000", "77843"},
                {"Приемная управляющего директора ОАО \"Саяногорский Алюминиевый Завод\"", "531200000", "21101"},
                {"Приемная управляющего директора ОАО \"Саяногорский Алюминиевый Завод\" (факс)", "531200000", "20266"},
                {"Приемная управляющего директора ОАО \"Саяногорский Алюминиевый Завод\" (факс)", "531200000", "20600"},
                {"Приемная управляющего директора ОАО \"Саяногорский Алюминиевый Завод\" (факс)", "531200000", "77710"},
                {"Приемная управляющего директора ОАО \"Саяногорский Алюминиевый Завод\" (факс)", "531200000", "77989"},
                {"Приемная управляющего директора ОАО \"Саяногорский Алюминиевый Завод\" (факс)", "531200000", "79932"},
                {"Приемная управляющего директора ОАО \"Саяногорский Алюминиевый Завод\" (факс)", "531200000", "79933"},
                {"Приемная управляющего директора ОАО \"Саяногорский Алюминиевый Завод\" (факс)", "531200000", "73905"},
                {"Управляющий директор ОАО \"Саяногорский Алюминиевый Завод\"", "531200000", "77401"},
                {"Управляющий директор ОАО \"Саяногорский Алюминиевый Завод\"", "531200000", "63644"},
                {"Офис управляющего директора ОАО \"Саяногорский Алюминиевый Завод\"", "531200000", "26488"},
                {"ОАО \"ГК-Гладенькая\" Президентский номер", "531200000", "21529"},
                {"Теплоресурс", "531200000", "73872"},
            };

            return array;
        }

        internal static string[,] Otb()
        {
            string[,] array =
            {
                {"Специалисты по охране труда", "531200050", "73380"},
            };

            return array;
        }

        internal static string[,] Pdo()
        {
            string[,] array =
            {
                {"Диспетчер завода", "531200020", "20356"},
                {"Диспетчер завода", "531200020", "73347"},
            };

            return array;
        }

        internal static string[,] Lawyers()
        {
            string[,] array =
            {
                {"Начальник юридического отдела", "531200010", "73368"},
                {"Начальник юридического отдела", "531200010", "77996"},
                {"Директор по правовым вопросам", "531200010", "77423"},
                {"Факс юридического одтела",      "531200010", "73611"},
            };

            return array;
        }

        internal static string[,] Electrolyse()
        {
            string[,] array =
            {
                {"Директор электролизного производства", "530200000", "73666"},
                {"Приемная факс",                        "530200000", "79925"},
                {"Руководитель проекта СУЭП",            "530200000", "77465"},

            };

            return array;
        }

        internal static string[,] Foundry()
        {
            string[,] array =
            {
                {"Директор ЛП",               "530300000", "77090"},
                {"Приемная ЛП (факс)",        "530300000", "77372"},
                {"Руководитель проекта СУЛП", "530300000", "77830"},
            };

            return array;
        }

        internal static string[,] Electrode()
        {
            string[,] array =
            {
                {"Директор по производству электродов", "530100000", "73456"},
            };

            return array;
        }

        internal static string[,] Energy()
        {
            string[,] array =
            {
                {"Главный энергетик", "531910000", "73570"},
                {"Главный энергетик", "531910000", "73571"},
                {"Оператор диспетчерской службы", "531910000", "73582"},
            };

            return array;
        }

        internal static string[,] Ecology()
        {
            string[,] array =
            {
                {"Директор по экологии и качеству", "530900000", "77856"},
                {"Главный метролог", "530900020", "73040"},
                {"Начальник отдела интегрированных систем менеджмента", "530900030", "77117"},
            };

            return array;
        }

        internal static string[,] Commerce()
        {
            string[,] array =
            {
                {"Коммерческий директор", "530600000", "73287"},
                {"Коммерческий директор", "530600000", "22054"},
                {"Приемная коммерческого директора", "530600000", "73372"},
                {"Приемная коммерческого директора", "530600000", "73923"},
                {"Начальник  ОООП", "530600030", "73004"},
                {"Специалист ОООП", "530600030", "73167"},
                {"Начальник ОМТС", "530600010", "73267"},
                {"Факс ОМТС", "530600010", "73321"},
                {"Специалист ОМТС", "530600010", "73006"},
                {"Специалист ОМТС", "530600010", "73317"},
                {"Специалист ОМТС", "530600010", "73822"},
                {"Специалист ОМТС", "530600010", "73027"},
                {"Специалист ОМТС", "530600010", "73828"},
                {"Специалист ОМТС", "530600010", "73512"},
                {"Менеджер ОМТС", "530600010", "73831"},
                {"Специалист ОМТС", "530600010", "77517"},
                {"Специалист ОМТС", "530600010", "77555"},
                {"Специалист ОМТС", "530600010", "73704"},
                {"Начальник отдела таможенного оформления", "530600020", "73237"},
                {"Специалист ТО", "530600040", "77154"},
                {"Начальника транспортного отдела", "530600040", "73966"},
                {"Специалист транспортного отдела", "530600040", "73318"},
                {"Начальник ЖДЦ", "530601000", "73961"},
                {"Товарный кассир филиала ст. Камышта", "530601000", "77296"},
            };

            return array;
        }

        internal static string[,] Personnel()
        {
            string[,] array =
            {
                {"Директор по персоналу", "530700000", "77552"},
                {"Приемная директора по персоналу (факс)", "530700000", "73441"},
                {"Приемная директора по персоналу", "530700000", "77991"},
                {"Руководитель проекта \"Профессионалы РУСАЛа\"", "530700090", "73903"},
                {"Начальник ООК", "530701000", "79945"},
                {"Специалист ОР и ПП", "530700030", "77765"},
                {"ФОК 10мкр", "530702000", "23122"},
                {"ФОК 10мкр", "530702000", "26138"},
                {"АДМИНИСТРАТИВНО-ХОЗЯЙСТВЕННЫЙ ОТДЕЛ", "", ""},
                {"АХО", "530700070", "73238"},
            };

            return array;
        }

        internal static string[,] Finance()
        {
            string[,] array =
            {
                {"Финансовый директор", "530800000", "73810"},
                {"Приемная финансового директора (факс)", "530800000", "73801"},
                {"Приемная финансового директора", "530800000", "77988"},
                {"Финансовый директор", "530800000", "26092"},
                {"Менеджер ПБО", "530800010", "77168"},
                {"Главный бухгалтер", "530800030", "73320"},
                {"Аудиторы", "530800030", "73038"},
                {"Аудиторы", "530800030", "73602"},
                {"Аудиторы", "530800030", "77197"},
                {"Аудиторы", "530800030", "77331"},
                {"Аудиторы", "530800030", "73263"},
                {"ОУСиКО", "530800050", "77269"},
            };

            return array;
        }

        internal static string[,] Security()
        {
            string[,] array =
            {
                {"Директор по защите ресурсов", "531100000", "73180"},
                {"Приемная начальника СЗЭР (факс)", "531100010", "73107"},
                {"Приемная начальника СЗЭР", "531100010", "23133"},
                {"СЛУЖБА ЗАЩИТЫ ЭКОНОМИЧЕСКИХ РЕСУРСОВ", "", ""},
                {"Нач-к отдела информационной безопасности", "531100020", "73531"},
                {"Нач.отд.спецохраны", "531100010", "73684"},
                {"Охрана ДИСа", "531100010", "23144"},
                {"Гараж ДИСа", "531100050", "63445"},
                {"", "531100010", "77121"},
                {"Менеджер", "531100010", "73860"},
                {"Менеджер", "531100010", "77531"},
                {"Специалист-детектив", "531100010", "73950"},
                {"ПЕРВЫЙ ОТДЕЛ, ШТАБ ГОиЧС", "", ""},
                {"Начальник отдела ГО и ЧС", "531100030", "73901"},
            };

            return array;
        }

        internal static string[,] TradeUnion()
        {
            string[,] array =
            {
                {"Приемная профкома ОАО \"САЗ\"", "531300020", "73050"},
            };

            return array;
        }

        internal static string[,] PressService()
        {
            string[,] array =
            {
                {"Руководитель пресс-службы", "531200040", "73790"},
                {"ЦСП РУСАЛа", "531200041", "62267"},
                {"Специалист пресс-службы", "531200040", "77405"},
            };

            return array;
        }

        internal static string[,] VeteranUnion()
        {
            string[,] array =
            {
                {"Председатель союза ветеранов", "", "20673"},
            };

            return array;
        }

        internal static string[,] Dis()
        {
            string[,] array =
            {
                {"Кв. № 94", "531300050", "21956"},
                {"Кв.№101 Президентский номер", "531300040", "22800"},
                {"Кв.№ 94", "531300050", "23510"},
            };

            return array;
        }

        internal static string[,] Other()
        {
            string[,] array =
            {
                {"Кв. Гаманович Г.Г.", "", "73820"},
                {"Кв. Гаманович Г.Г. (Internet)", "", "73820"},
                {"ЗАО \"Смена плюс\" Специалист по кадрам", "", "73881"},
                {"Абакан", "", "243777"},
            };

            return array;
        }
    }
}