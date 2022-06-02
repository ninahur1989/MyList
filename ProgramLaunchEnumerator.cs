using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class ProgramLaunchEnumerator : IEnumerator<string>
    {
        private string[] _date;
        private int _position = -1;
        public ProgramLaunchEnumerator(string[] dates)
        {
            _date = dates;
        }

        public string Current
        {
            get
            {
                if (_position == -1 || _position >= _date.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return _date[_position];
            }
        }

        object IEnumerator.Current => _date[_position];

        public bool MoveNext()
        {
            if (_position < _date.Length - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose()
        {
        }
    }
}
