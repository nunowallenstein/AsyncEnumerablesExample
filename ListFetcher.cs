using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncEnumerablesExample
{
    internal class ListFetcher
    {
        private readonly Random _randomGen;

        internal ListFetcher()
        {
            _randomGen = new Random();
        }

        public async Task<IEnumerable<int>> GetAllInts()
        {
            var list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                list.Add(_randomGen.Next(1, 100));
            }
            return list;
        }

        public async IAsyncEnumerable<int> GetAllIntsAsyncEnumerable()
        {

            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                yield return _randomGen.Next(1, 100);
            }
        }

    }
}
