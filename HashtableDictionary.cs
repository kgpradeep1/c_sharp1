using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace c_sharp1
{
    internal class HashtableDictionary
    {
        public static void Main()
        {
           
            DictionaryDemo();
            HashtableDemo();
        }
        public static void DictionaryDemo()
        {
            //json-data tranfer
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("in", "India");
            dictionary.Add("us", "United States");
            dictionary.Add("uk", "United Kingdom");
            Console.WriteLine("Keys in the Dictionary");
            var key = new List<string>(dictionary.Keys);
            foreach (var k in key)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Values in the Dictionary");
            var value = new List<string>(dictionary.Values);
            foreach (var v in value)
            {
                Console.WriteLine(v);
            }
            //Console.WriteLine("Non key value:{0}", dictionary["ja"]);

        }
        /// <summary>
        /// HASHTABLE-NON-GENERIC-RANDOM RETRIEVAL
        /// NOT TYPE SPECIFIC-BOXING/UNBOXING-NONKEY VALUE RETURN NULL
        /// </summary>

        public static void HashtableDemo()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Numan3");
            hashtable.Add(2, "Numan2");
            hashtable.Add("N", "Numan");
            Console.WriteLine("HASHTABLE");
            ICollection collection = hashtable.Keys;
            foreach (var k in collection)
            {
                Console.WriteLine(hashtable[k]);
            }
            Console.WriteLine("Non-key value:{0}", hashtable[3]);

        }
    }
}
