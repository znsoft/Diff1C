using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Consolediff.filetree
{
    class Загрузчик
    {
        public FileInfo Файл;
        public ДеревоМетаданных КореньДерева;
        public Загрузчик(string ИмяФайла, int МаксимумУровней, Action<ДеревоМетаданных, string, long> Делегат)
        {
            КореньДерева = new ДеревоМетаданных(ИмяФайла, null, null);
            Файл = new FileInfo(ИмяФайла);
            long Размер = Файл.Length;
            var ЧтениеТекста = Файл.OpenText();

            ДеревоМетаданных ТекущаяВетвь = КореньДерева;
            bool НайденоНачало = false;
            
            while (!ЧтениеТекста.EndOfStream)
            {
                string Строка = ЧтениеТекста.ReadLine();
                int Отступ = Строка.LastIndexOf(Ключ.Табуляция);
                while (ТекущаяВетвь != null)
                    if (ТекущаяВетвь.Отступ >= Отступ) ТекущаяВетвь = ТекущаяВетвь.Родитель; else break;
                if(ТекущаяВетвь == null) ТекущаяВетвь = КореньДерева;
                if (!НайденоНачало)
                {
                    if (Строка.Contains(Ключ.Начало))
                    {
                        НайденоНачало = true;
                        ТекущаяВетвь = new ДеревоМетаданных(Ключ.Начало, КореньДерева, КореньДерева);
                    }

                    continue;
                }
                ТекущаяВетвь = new ДеревоМетаданных(Строка, ТекущаяВетвь, КореньДерева);
                Делегат(ТекущаяВетвь, Строка, Размер);
            }

        }
    }
}
