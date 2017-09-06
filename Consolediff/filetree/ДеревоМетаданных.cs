using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Consolediff.filetree
{
    class ДеревоМетаданных
    {
        public string Имя;
        private string полноеИмя;
        public int Отступ,уровень;
        private int суммаВложенных;
        // public Dictionary<string, ДеревоМетаданных> Подчиненные;
        public List<ДеревоМетаданных> Подчиненные;

        public ДеревоМетаданных Родитель;
        public ДеревоМетаданных Корень;


        public int СуммаВложенныхРазличий
        {
            get
            {
                return суммаВложенных;
            }

            set
            {
                суммаВложенных += value;
                if (Родитель != null) Родитель.СуммаВложенныхРазличий = value;
            }
        }

        public string ПолноеИмя
        {
            get
            {
                return Имя+ " (" + суммаВложенных.ToString()+")";
            }

        }

        public ДеревоМетаданных(string Имя, ДеревоМетаданных Родитель, ДеревоМетаданных Корень) {
            суммаВложенных = 0;
            
            Отступ = Имя.LastIndexOf(Ключ.Табуляция);
            this.Имя = Имя.Trim();
            this.Родитель = Родитель;
            this.Корень = Корень;
            Подчиненные = new List<ДеревоМетаданных>();
            try
            {
                Родитель?.Подчиненные.Add(this);
            }
            catch (Exception e) { }
            if (Родитель != null) уровень = Родитель.уровень + 1; else уровень = 0;


        }

        public ДеревоМетаданных НайтиПодчиненногоПоИмени(string Имя) {
            foreach (var Подчиненный in Подчиненные) 
                if (Подчиненный.Имя.Contains(Имя)) return Подчиненный;
            return null;
        }


        public List<ДеревоМетаданных> ПолучитьРазличияРекурсией(ДеревоМетаданных ВетвьДерева2, Action<ДеревоМетаданных, string, long> Делегат)
        {
            List<ДеревоМетаданных> Результат = new List<ДеревоМетаданных>();
            foreach (var Лист in Подчиненные)
            {
                Делегат(Лист, Лист.Имя, 1);
                if (Лист.Имя.Contains(Ключ.Порядок)) continue;
                var Лист2 = ВетвьДерева2.НайтиПодчиненногоПоИмени(Лист.Имя);
                if(Лист2!=null)
                {
                    var Различия = Лист.ПолучитьРазличияРекурсией(Лист2, Делегат);
                    Результат.AddRange(Различия);
                    continue;
                }
                Лист.СуммаВложенныхРазличий = 1;
                Результат.Add(Лист);
                
            }

            return Результат;
        }

    }
}
