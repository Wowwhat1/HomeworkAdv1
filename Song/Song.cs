using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    internal class Song
    {
        public string _typeList;
        public string TypeList
        {
            get => _typeList;
            set => _typeList = value;
        }
        public string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string _time;
        public string Time
        {
            get => _time;
            set => _time = value;
        }

        public Song()
        {

        }
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
    }
}
