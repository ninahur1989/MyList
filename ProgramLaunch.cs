using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class ProgramLaunch : IEnumerable
    {
        private string[] _date = { DateTime.Now.ToString(), "2 недели назад", "прошлым летом" };
        public IEnumerator GetEnumerator()
        {
            return new ProgramLaunchEnumerator(_date);
        }

        public void Add(string your)
        {
            Array.Resize(ref _date, _date.Length + 1);
            if (your == null)
            {
                your = DateTime.UtcNow.ToString();
            }
            else
            {
                for (int i = 0; i < _date.Length; i++)
                {
                    if (_date[i] == null)
                    {
                        _date[i] = your;
                        break;
                    }
                }
            }
        }

        public void AddRange(string[] your)
        {
            if (your.Length == 0)
            {
                throw new NullReferenceException();
            }

            Array.Resize(ref _date, _date.Length + your.Length);
            int p = _date.Length;
            for (int i = 0; i < your.Length; i++)
            {
                _date[p - your.Length] = your[i];
                p++;
            }
        }

        public void Remove(string your)
        {
            for (int i = 0; i < _date.Length; i++)
            {
                if (your == _date[i])
                {
                    _date[i] = "";
                    Sort();
                    Array.Reverse(_date);
                    Array.Resize(ref _date, _date.Length - 1);
                }
            }
        }

        public void RemoveAt(int your)
        {
            if (your >= 0 && your < _date.Length)
            {
                _date[your] = "";
                Sort();
                Array.Reverse(_date);
                Array.Resize(ref _date, _date.Length - 1);
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void Sort()
        {
            for (int i = 0; i < _date.Length; i++)
            {
                for (int k = i + 1; k < _date.Length; k++)
                {
                    if (_date[i].Length > _date[k].Length)
                    {
                        string str1 = " ";
                        str1 = _date[i];
                        _date[i] = _date[k];
                        _date[k] = str1;
                    }
                }
            }
        }
    }
}
