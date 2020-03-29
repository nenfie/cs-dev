using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayCollectionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAY LIST Usage
            ArrayList _angka = new ArrayList();
            // Add ArrayList
            foreach (int angka in new int[4] { 1, 2, 3, 4 })
            {
                _angka.Add(angka);
            }

            // Insert ArrayList
            _angka.Insert(_angka.Count - 1, 10);
            
            // Remove ArrayList
            _angka.Remove(4);

            // RemoveAt ArrayList
            _angka.RemoveAt(2);

            // Access ArrayList
            foreach (int angka in _angka)
            {
                Console.WriteLine(angka.ToString() + " ada pada ArrayList");
            }

            Console.ReadLine();


            // QUEUE Usage
            Queue _angka2 = new Queue();
            // Enqueue
            foreach (int angka in new int[4] { 1, 2, 3, 4 })
            {
                _angka2.Enqueue(angka);
                Console.WriteLine(angka.ToString() + " masuk Queue");
            }

            // Dequeue
            while (_angka2.Count > 0)
            {
                int i = (int)_angka2.Dequeue();
                Console.WriteLine(i.ToString() + " keluar Queue");
            }

            Console.ReadLine();


            // STACK Usage
            Stack _angka3 = new Stack();
            // Push Stack
            foreach (int angka in new int[4] { 1, 2, 3, 4 })
            {
                _angka3.Push(angka);
                Console.WriteLine(angka.ToString() + " Push ke Stack");
            }

            // Pop Stack
            while (_angka3.Count > 0)
            {
                int i = (int)_angka3.Pop();
                Console.WriteLine(i.ToString() + " Pop dari Stack");
            }

            Console.ReadLine();


            // HASHTABLE Usage
            Hashtable _umur = new Hashtable();
            _umur["rahman"] = 24;
            _umur["tyo"] = 30;
            _umur["agung"] = 26;
            _umur["nugie"] = 31;

            // Access HashTable
            foreach (DictionaryEntry element in _umur)
            {
                string nama = element.Key.ToString();
                int umur = int.Parse(element.Value.ToString());
                Console.WriteLine("Nama {0}, Umur {1}", nama, umur);
            }

            Console.ReadLine();


            // SORTEDLIST Usage
            SortedList _umur2 = new SortedList();
            _umur2["rahman"] = 24;
            _umur2["tyo"] = 30;
            _umur2["agung"] = 26;
            _umur2["nugie"] = 31;

            // Access SortedList
            foreach (DictionaryEntry element in _umur2)
            {
                string nama = element.Key.ToString();
                int umur = int.Parse(element.Value.ToString());
                Console.WriteLine("Nama {0}, Umur {1}", nama, umur);
            }

            Console.ReadLine();

        }
    }
}
