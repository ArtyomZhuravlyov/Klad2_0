﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klad.Models
{
    public class DescriptionCatalog
    {
       // public static DescriptionCatalog instance { get; set; }
        //Не стал писать в базу так как на хостинге можно держать только одну
        /// <summary>
        /// Описание каталогов под товарами
        /// </summary>
        public static Dictionary<string, Dictionary<string, string>> DiscriptionCatalog { get;private set;}

        //public Dictionary<string, Dictionary<string, string>> GetDiscriptionCatalog()
        //{
        //    return DiscriptionCatalog;
        //}

        //public static DescriptionCatalog GetInstance()
        //{
        //    if (instance == null)
        //        instance = new DescriptionCatalog();
        //    return instance;
        //}

        public DescriptionCatalog()
        {
            DiscriptionCatalog = new Dictionary<string, Dictionary<string, string>>()
            {
                { "ЗДОРОВЬЕ Похудение", new Dictionary<string, string>
                    {

                         {"\t\tАлтайские препараты от лишнего веса",

                         "\t\tНе всегда диета и изнурительный фитнес дают результат, порой организму требуется помощь. Чтобы наладить обмен веществ и сдвинуть с мертвой точки стрелку весов, предлагаем натуральные средства от лишнего веса по приемлемой цене" +
                        ". В каталоге представлены уникальные лечебные комплексы, указана стоимость препаратов и особенности их применения."
                         },

                        {"\t\tКак действуют натуральные средства от лишнего веса",

                        "\t\tДобавление в состав исключительно природных компонентов придает алтайским средствам от лишнего веса уникальные детокс-свойства. Нативные волокна из различных зерен и трав, обогащенные биогенными материалами растительного происхождения, эффективно воздействуют на оборот липидов, белков и углеводов, ускоряя метаболизм," +
                        " предупреждая застои и нарушения ферментации желудка, стимулируют здоровую моторику кишечника."
                        },

                        {"\t\tАлтайские средства от лишнего веса - легкий путь к совершенству",

                        "\t\tАлтайские препараты от лишнего веса - мощные стимуляторы обменных процессов. Продаются целебные медикаменты в удобном виде - капсул, таблеток, лечебных чаев или фитосборов. Они избавляют от приступов голода, активизируют отток лимфы, " +
                        "вывод токсических веществ из организма, контролируют расщепление жиров.Корректировать вес с натуральными средствами для похудения очень просто, дешево и безопасно. Приобрести недорого понижающие холестерин и вымывающие из организма шлаки аптечные снадобья можно в интернет-магазине."
                        }
                    }
                },

                {
                    "ЗДОРОВЬЕ Для горла и носа", new Dictionary<string, string>
                    {

                        { "Натуральные средства для лечения горла и носа",

                        "«Сашера-мед» в Москве представляет алтайские препараты для носа и горла. Полностью натуральный состав нативных капель действует как эффективное антивирусное и противопростудное средство."
                        },

                        {
                            "Натуральные алтайские средства для носа и горла: принцип действия",

                            "Среди активных компонентов аптечного комплекса из серии «Мастер» - алтайские лекарственные травы и масла. В сочетании с прополисом исцеляющая формула уникального природного снадобья" +
                            " быстро прогоняет возбудителей инфекционных заболеваний лор-органов.Биогенные добавки оказывают общеукрепляющий, лечебный и профилактический эффект:" +
                            "\nАлтайские средства для носа восстанавливают слизистую оболочку органов дыхания, убирают воспаления и аллергические отеки, нормализуют вазомоторную деятельность организма." +
                            " Натуральные препараты для горла устраняют первопричину боли - блокируют вредоносные вирусы. Органелло-капли быстро облегчают состояние больного," +
                            " снимают раздражение слизистой оболочки, усиливают местный иммунитет, предупреждают осложнения."
                        }

                    }
                },

                {
                     "ЗДОРОВЬЕ Для зрения", new Dictionary<string, string>
                     {
                         {"Лечение глаз натуральными препаратами",

                         "Натуральные средства для глаз от «Сашера-мед» созданы из биогенных материалов растительного происхождения. Алтайские травы и ягоды, экстракты сибирских деревьев придают уникальной формуле силу природы," +
                         " помогают восстановить здоровье зрительной системы, являются превосходной профилактикой офтальмологических заболеваний."
                         },
                         {
                             "Чем отличаются натуральные средства для зрения от обычных лекарств",

                             "Лечебные алтайские средства для зрения стоят не дороже медикаментов, однако их стоимость более оправдана. " +
                             "Безопасность и мягкое воздействие натурального состава гораздо результативнее справляется с такими задачами, как:" +
                             "\r\nадаптация чувствительных элементов глаза к чрезмерно яркому или интенсивному освещению;" +
                             "\r\nустранение воспалительных процессов; " +
                             "\r\nвосстановление остроты зрения; подпитка минералами и витаминами; " +
                             "\r\nулучшение кровотока;" +
                             "\r\nзащита глаз от переутомления."
                         }
                     }
                },

                {
                    "ЗДОРОВЬЕ Для мозговой активности", new Dictionary<string, string>
                    {
                        {"Мозговая активность",

                        "Ни для кого не секрет, что различного рода заболевания являются ровесниками самого человечества. Только если в древности люди страдали от механических ран и переломов, полученных в бою или схватке с диким животным, " +
                        "то наши современники чаще жалуются на мигрени, головные боли, рассеянность и бессонницу. Кто-то назовет такую ситуацию классическим «горем от ума» - наш образ жизни накладывает свой отпечаток на общее состояние здоровья." +
                        " Это только на первый взгляд, кажется, что современные проблемы примитивны по сравнению с неприятностями наших предков. На самом деле проблема лежит глубоко, и жизнь в состоянии непрерывного стресса не сулит ничего хорошего. " +
                        "Преодолеть постоянный стресс и сонливость помогут алтайские препараты для мозга – недорогие натуральные «умственные ускорители», благотворно влияющие на мозговую деятельность и концентрацию человека."
                        },

                        {"Натуральные средства для мозга – принцип действия и эффективность",

                        "Принимая лечебные натуральные средства для мозга, вы сможете быстро ощутить улучшения в своем состоянии:"+
                       "\nповышается концентрация,"+
                       "\nулучшается бдительность,"+
                       "\nпоявляется чувство внутренней гармонии,"+
                       "\nулучшается память,"+
                       "\nулучшается работа сердечно-сосудистой системы,"+
                       "\ncтабилизируется настроение."
                        }
                    }
                },

                {
                    "ЗДОРОВЬЕ Для печени Для почек", new Dictionary<string, string>
                    {
                        { "Принимаем алтайские средства для почек – как распознать начинающийся недуг",

                        "Принимать натуральные алтайские средства для почек рекомендуется тем, кто желает предотвратить развитие недуга," +
                        " или заметил у себя симптомы приближающейся болезни, не прибегая к дорогостоящим или синтетическим аптечным препаратам." +
                        " К признакам ухудшения состояния почек можно отнести:"+
                        "\nболезненность в суставах и мышцах,"+
                        "\nучащенное и болезненное мочеиспускание,"+
                        "\nрвота, тошнота, наличие белковых хлопьев в моче."+
                        "\nОсновной причиной развития почечных недугов считается переохлаждение: \nвоздействие низких температур приводит к сужению сосудов, что, " +
                        "\nв свою очередь, вызывает нарушения в работе почечной ткани. Если болезнь перешла в серьезную стадию, без специальных медицинских препаратов не обойтись," +
                        " а вот начинающийся недуг легко победить, принимая натуральные препараты для почек Алтайского происхождения, ведь их эффективность проверена годами, " +
                        "а о волшебных свойствах минералов Алтайского Края уже давно ходят легенды." +
                        "\n Алтайские средства для печени и почек, может, и не являются лечебной панацеей, но облегчить состояние больного и значительно улучшить его самочувствие им по силам." +
                        " Тем более, если терапия начата вовремя, и заболевание не успело перейти в хроническую фазу."
                        }

                    }
                },

                 {
                    "ЗДОРОВЬЕ Для слуха", new Dictionary<string, string>
                    {
                        { "Алтайские препараты для слуха – когда прием оправдан",

                        "Нарушения слуха способны доставить человеку массу неприятностей – неспособность воспринимать звуки окружающего мира лишает жизнь ярких красок." +
                        " И если особенно сложные случаи глухоты (например, врожденная или приобретенная после серьезной травмы) не поддаются лечению, то временное ухудшение состояния," +
                        " вызванное простудой или воспалительным процессом, вполне можно вылечить, принимая натуральные средства для слуха – недорогой аналог дорогостоящим аптечным препаратам." +
                        "Если потеря или ослабление слуха не вызваны необратимыми процессами или травмами, то причин такого явления может быть несколько:\n"+
                        "несоблюдение элементарных правил личной гигиены – банальные серные пробки,"+
                        "воспалительные процессы вследствие простудных заболеваний,"+
                        "возрастные изменения и отмирание слухового нерва."+
                        "И если в первом случае исправить ситуацию можно при помощи механической чистки, то в двух последних ситуациях необходимо проявить повышенное внимание к своему здоровью, чтобы не утратить дар слышать."
                        },

                        {
                            "Натуральные средства для слуха – простое решение сложной проблемы",

                            "Применение лечебных средств медикаментозной группы не всегда оправданно: " +
                            "такие препараты продаются по высокой цене, и часто обладают рядом побочных эффектов." +
                            " Другое дело – алтайские средства для слуха, привезенные с Алтайского Края:" +
                            " они натуральны, стоят дешевле аптечных аналогов, " +
                            "особенно – если покупать их посредством интернет-магазина " +
                            "(тогда стоимость препарата для покупателей из Москвы будет такой же, как и для жителей отдаленных провинциальных поселков)." +
                            " При этом вы получаете качественный продукт, прошедший все необходимые проверки, и зарекомендовавший себя," +
                            " как эффективное средство в непростом деле восстановления слуха."
                        }
                    }
                },

                 {
                    "ЗДОРОВЬЕ Для суставов", new Dictionary<string, string>
                    {
                        { "Заболевания суставов",

                        "Все заболевания, связанные с болевыми ощущениями в суставах, связках и мышцах, можно обозначить общим названием – ревматические недуги. " +
                        "Проявлений таких болезней может быть несколько: это и артроз, поражающий непосредственно суставы, и артрит, представляющий собой воспалительный процесс, или подагра." +
                        " Всем известно, что полностью восстановить поврежденный сустав невозможно, и если не предпринимать никаких мер, то со временем суставы деформируются, ограничивается их подвижность," +
                        " а больного мучают постоянные боли."
                        },

                        {
                            "Натуральные средства для суставов – предотвращаем болезнь",

                            "Но не все так страшно – болезнь не развивается в одночасье. Достаточно внимательно прислушиваться к своему организму и вовремя реагировать на его сигналы, чтобы не допустить развития серьезной проблемы." +
                            " Один из вариантов терапии – натуральные средства для суставов, изготовленные на основе минералов Алтайского Края. Их применение, наряду с обязательным соблюдением общих врачебных рекомендаций, позволяет быстро и недорого избавиться от первых ревматических проявлений, " +
                            "не прибегая к дорогостоящим аптечным медикаментам. "
                        },
                        {
                            "Алтайские препараты для суставов – воздействие на организм",

                            "Принимая алтайские препараты для суставов, вы сможете в короткие сроки заметить положительный эффект от такой щадящей терапии:"+
                            "\nуходят болевые ощущения,"+
                            "\nуменьшаются отеки и воспаления,"+
                            "\nвосстанавливается подвижность суставного аппарата,"+
                            "\nулучшается настроение и качество жизни."+
                            "\nИнтернет-магазин Сашера-Мед предлагает приобрести лечебные натуральные препараты на основе древних Алтайских рецептов по минимальной стоимости – цена аналогичных средств в стандартной аптечной сети будет на порядок выше." +
                            "\nЦеновая политика магазина едина для всех покупателей – из Москвы или из регионов, вы вряд ли найдете дешевле!"

                        }
                    }
                },


                 {
                    "ЗДОРОВЬЕ Женское здоровье", new Dictionary<string, string>
                    {
                        { "",

                        "Женщины обладают неповторимым бесценным даром – способностью даровать жизнь и продолжать род. Но такая миссия женского организма зачастую связана с рядом проблем –" +
                        " правильное функционирование половой системы женщин часто связано с трудностями ввиду сложности строения самой системы." +
                        " Кроме того, на ее состояние влияет множество сопутствующих факторов – от генетических и психологических, до экологии и индивидуальных особенностей строения отдельных органов."+
                        "Серьезные нарушения и недуги требуют профессиональной помощи медиков и применения аптечных препаратов, но сама женщина может поддержать собственное здоровье," +
                        " принимая натуральные алтайские препараты для женского здоровья – недорогие лечебные средства, созданные на основе вековых рецептов жителей Алтайского края."
                        },

                        {
                            "Алтайские препараты для женского здоровья – разбираемся в недугах",

                            "Больше всего неприятностей женщинам доставляет несколько хворей: это климакс (естественный физиологический процесс, сопровождающийся болезненными или неприятными ощущениями), " +
                            "воспалительные заболевания половых органов, вызываемые патогенной микрофлорой. Натуральные средства для женского здоровья, купленные в интернет-магазине Сашера-Мед, возможно, " +
                            "и не станут панацеей от болезни, но облегчить состояние пациентки или даже предотвратить заболевание они могут."
                        },

                    }
                },

                 {
                    "ЗДОРОВЬЕ Укрепление иммунитета", new Dictionary<string, string>
                    {
                        { "Свойства алтайских препаратов на основе натуральных компонентов",

                        "Натуральный состав лечебных средств – залог успешного поднятия иммунитета." +
                        " В каталоге нашего магазина представлены те препараты, которые зарекомендовали себя как действенные помощники при:"+
                        "\nинфекционных заболеваниях;" +
                        "\nпаразитарных и бактериальных процессах;" +
                        "\nсниженной сопротивляемости иммунной системы;" +
                        "\nпроблемах с микрофлорой кишечника;" +
                        "\nболях в мышцах и суставах;"+
                        "\nранениях кожи"+
                        "\nАлтайские средства дешево стоят, но хорошо помогают при комплексном воздействии и местном применении." +
                        " Достичь требуемого эффекта можно, применяя средства исключительно согласно инструкции от производителя."
                        }
                    }
                },

                {
                    "ЗДОРОВЬЕ Нервная система", new Dictionary<string, string>
                    {
                        { "Высокоэффективные алтайские средства для нервной системы",

                        "Стрессы, нарушение сна, слишком загруженный образ жизни выматывают нервную систему человека." +
                        " В будущем это сказывается негативно на самочувствии и производительности каждого." +
                        " Пополнить силы и восстановить бодрость помогут алтайские натуральные препараты для нервной системы."
                        },

                        {
                            "Действенные препараты с натуральным составом недорого",

                            "Человек, страдающий от нарушения работы нервной системы, может испытывать ряд неприятных ощущений. Верными спутниками в такой период могут стать:"+
                            "\nдиарея;"+
                            "\nрвота;"+
                            "\nучащенное сердцебиение;"+
                            "\nнарушение сна;"+
                            "\nнарушение менструального цикла у женщин;"+
                            "\nпсихоэмоциональное напряжение;"+
                            "\nпроявления агрессии или тревоги;"+
                            "\nнавязчивые мысли;"+
                            "\nэпилептические состояния;"+
                            "\nрассеянный склероз;"+
                            "\nвегетососудистые нарушения."
                        }
                    }
                },

                {
                    "ЗДОРОВЬЕ От паразитов", new Dictionary<string, string>
                    {
                        { "Свойства и эффекты от применения натуральных препаратов",

                        "Паразитирующие организмы наносят вред человеку. Часто обнаружить наличие гельминтоза удается не сразу, а это приводит к потерям времени и нанесению большого вреда организму." +
                        " Справиться с последствиями таких заболеваний, и восстановить пораженные области можно комплексным лечением и витаминотерапией." +
                        "Цель применения аптечных препаратов – очищение организма от паразитов. При помощи лечебных средств с натуральным составом удается:" +
                         "\nвосстановить органы и системы органов, которые пострадали от воздействия паразитов;"+
                            "\nпредотвратить развитие лимфотоксикоза;"+
                            "\nнормализовать состав собственной микрофлоры кишечника;"+
                            "\nвосстановить иммунную систему и сделать ее более устойчивой к инфекциям и вирусам;"+
                            "\nпредотвратить возможность повторного заражения гельминтами."+
                            "Важной особенностью применения алтайских средств, стала выработка устойчивого иммунитета к паразитам, что предотвращает возможность повторения заболевания в будущем."
                        },

                    }

                },

                {
                    "ЗДОРОВЬЕ Пищеварительная система", new Dictionary<string, string>
                    {
                        { "Натуральный состав и комплексное действие лечебных препаратов",

                        "В каталоге продукции представлены лечебные препараты, в состав которых входят натуральные компоненты:" +
                         "\nягоды годжи;"+
                            "\nрастительные компоненты интенсивного действия;"+
                            "\nорганические и неорганические соединения – продукты жизнедеятельности насекомых, животных и растений;"+
                            "\nприродные биологически активные вещества."+
                            "Комплексное воздействие дешевых компонентов обеспечивает общее укрепление организма, повышает метаболизм и улучшает самочувствие." +
                            " На сайте нашей компании клиенты приобретают сертифицированные товары, соответствующие действующими нормам для пищевой продукции."
                        },

                        {
                            "Эффект от применения алтайских препаратов не заставит себя ждать",

                            "Чайные напитки и Алтайское мумие - алтайские препараты для пищеварительной системы, которые славятся благотворным воздействием на организм." +
                            " Используя такие недорогие препараты можно:"+
                            "\nvсбалансированно снизить массу тела;"+
                            "\nустранить жировые отложения, не вредя собственному здоровью;"+
                            "\nустранить воспаления в желудке, кишечнике, поджелудочной железе и печени;"+
                            "\nуменьшить воздействие вирусов и инфекций на пищеварительную систему;"+
                            "\nнормализовать микрофлору кишечника;"+
                            "\nускорить процесс лечения панкреатита, гельминтозы, колита, язв, гепатоза печени и пр."
                        }

                    }
                },

                {
                    "ЗДОРОВЬЕ От аллергии", new Dictionary<string, string>
                    {
                        { "Как действуют лечебные алтайские средства",

                        "Ежедневно мы проходим через множество испытаний. Стрессы на роботе, переутомление и недосып. Все эти факторы приводят к снижению иммунитета." +
                        " Обретенная или хроническая аллергия – это следствие сбоя в защитной системе организма." +
                        "Порой самые безобидные вещества (мед, пряные специи и прочее), становятся причиной надоедливых симптомов." +
                        " Используя натуральные препараты от аллергии можно недорого минимизировать неприятные симптомы."+
                        "\nАлтайская целебная косметика, представляет собой аптечные продукты. В их основе лежат следующие лечебные компоненты:"+
                         "\nКора лиственницы сибирской – обладает противовоспалительным действием. Снимает аллергический зуд и сухость кожи. Нормализует иммунные процессы, выводит аллергены из организма;"+
                            "\nКрапива (листья и вытяжки из корней). Используется как антисептическое средство, препятствует развитию инфекций на слизистых. Подавляет выработку гистамина и повышает стойкость к аллергену;"+
                            "\nКаменное масло – обладает успокаивающим эффектом. Восстанавливает обменные процессы изнутри. Убирает дерматиты, жжения и отшелушивания на коже. Уменьшает слезотечение и отек при аллергическом рините;"
                        },

                        {
                            "Эффект от применения алтайских препаратов не заставит себя ждать",

                            "Чайные напитки и Алтайское мумие - алтайские препараты для пищеварительной системы, которые славятся благотворным воздействием на организм." +
                            " Используя такие недорогие препараты можно:"+
                            "\nvсбалансированно снизить массу тела;"+
                            "\nустранить жировые отложения, не вредя собственному здоровью;"+
                            "\nустранить воспаления в желудке, кишечнике, поджелудочной железе и печени;"+
                            "\nуменьшить воздействие вирусов и инфекций на пищеварительную систему;"+
                            "\nнормализовать микрофлору кишечника;"+
                            "\nускорить процесс лечения панкреатита, гельминтозы, колита, язв, гепатоза печени и пр."
                        }

                    }
                },

                {
                    "ЗДОРОВЬЕ От варикоза От геморроя", new Dictionary<string, string>
                    {
                        { "Варикоз и геморрой - две составляющие одного целого",

                        "Если вы заметили выпирающие синеватые вены или их вздутие, тогда вам необходимо воспользоваться дешевым алтайским средством от варекоза с уникальными лечебными свойствами." +
                        " К сожалению, данная проблема беспокоит людей, несмотря на возраст, здоровье и образ жизни. " +
                        "Так или иначе, это не повод оградить себя от радостей жизни, не существует нерешаемых проблем."
                        
                        },

                        {
                            "Что лучше использовать для предотвращения варикоза",

                            "Варикоз может образоваться на вашем теле из-за множества факторов:" +
                            "\nгенетическое наследие;"+
                            "\nсидячий или стоячий образ жизни;"+
                            "\nожирение;"+
                            "\nво время беременности;"+
                            "\nвозрастная слабость."+
                            "\nТаким образом, женщины больше подвергаются заболеванию вен. Важно вовремя купить натуральные препараты от варекоза, " +
                            "чтобы не усугубить свое состояние. Применяйте меры по устранению проблем быстро, ведь от этого зависит ваше здоровье, настроение, жизнь."+
                            "\nНа странице вы увидите натуральные средства для наружного применения, которые за короткий промежуток времени избавят вас от дискомфорта, болей и отека ног. " +
                            "Регулярное применение препаратов поможет избежать нежелательных процессов, уменьшить воспаление и улучшить состояние сосудов."+
                            "\nИз-за давления на вены, расположенные в прямой кишке, образуется развитие геморроя. Поэтому эти два заболевания тесно связаны между собой." +
                            " Если ваша работа основана на сидячем или стоячем процессе, то вы рискуете усугубить ситуацию. Поэтому без применения натуральных препаратов от геморроя не обойтись."
                        },


                    }
                },

                 {
                    "ЗДОРОВЬЕ При диабете", new Dictionary<string, string>
                    {
                        { "Современное лечение сахарного диабета",

                        "Сахарный диабет описывается как заболевание, во время которого уровень глюкозы в организме человека повышен. Поэтому если вы заметили за собой изначальные симптомы," +
                        " такие как: повышенная жажда, частое мочеиспускание, постоянная усталость, появление грибковых инфекций, резкое похудание, падение зрения и ослабление памяти," +
                        " тогда нужно в срочном порядке пройти обследование и заняться лечением своего здоровья."
                        },

                        {
                            "Причины и разновидности заболевания",

                            "Основной причиной возникновения диабета являются проблемы с поджелудочной железой, которая в определенный момент перестает вырабатывать достаточное количество инсулина." +
                            " Чтобы не запускать заболевание рекомендуем недорогие лечебные натуральные средства при диабете, которые превосходят аптечные аналоги." +
                            "\nЕсли не следить за своим состоянием здоровья или лечить диабет неправильно, то можно остаться инвалидом на всю жизнь из-за осложнений:"+
                            "\nзаболевания сердечно-сосудистой системы;"+
                            "\nпочечной недостаточности;"+
                            "\nязвы;"+
                            "\nпотери зрения;"+
                            "\nкома."+
                            "\nТПомимо алтайских препаратов, не забывайте вести здоровый образ жизни и при возможности отказаться от курения." 
                        },


                    }
                }

            };
        }


       
                    
    }
}
