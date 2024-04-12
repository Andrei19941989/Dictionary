using System;
using System.Collections;
using System.Collections.Generic;

namespace Dict3
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Dictionary<string, string> m = new Dictionary<string, string>()//первый словарь-ключ(имя птиомца)-значения это имя хозяина
            {
                {"Hatiko", "Parker"},
                {"Fido", "John"},
                {"Barry", "Parker"},
                {"Rocky", "John"}
            };
            Dictionary<string, List<string>> v = new Dictionary<string, List<string>>();//новый словарь чтобы ключ это имя хозяина а значение это список питомца
            foreach (string k in m.Keys)//цикл по всем ключам первого словаря
            {
                if(v.ContainsKey(m[k]))//если вторйо словарь новый сощдердит такое имя хозяина 
                {
                    v[m[k]].Add(k);//в список добовляем нового питомца
                }
                else//если такого хоязина еще не было в словаре
                {
                    List < string > b = new List<string>();//список кличек-питомцев
                    b.Add(k);//добавили первого питомца
                    v[m[k]] = b;//присвоили этот список по ключу
                }
            }

            foreach (string c in v.Keys)//перебираем ключи из ноовго словаря
            {
                Console.Write(c + " ");//выводим ключ-тоесть имя хозяина
                foreach (string h in v[c])//перебираем список питомцев
                {
                    Console.Write(h + " ");//выводим клички питомцев
                }
                Console.WriteLine();
            }

        }
    }
}