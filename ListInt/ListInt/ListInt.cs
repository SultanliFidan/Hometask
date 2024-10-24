using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInt
{
     class ListInt
    {
        private int[] _nums = new int[0]; 
        public int this[int index]
        {
            get
            {
                return _nums[index];
            }
            set
            {
                _nums[index] = value;
            }
        }


        public void Add(int num)
        {
            Array.Resize(ref _nums, _nums.Length + 1);
            _nums[_nums.Length - 1] = num;
        }

        public void Add(params int[] nums)
        {
            int index = _nums.Length;
            Array.Resize(ref _nums, _nums.Length + nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                _nums[index+i] = nums[i];
            }
        }

        public bool Contains(int num)
        {
            foreach (int i in _nums)
            {
               if (i == num)
                {

                  return true;
                }
            }
            return false;
        }

        public int Pop()
        {
            int num = _nums[_nums.Length - 1];
            Array.Resize(ref _nums,_nums.Length - 1);
            return num;
        }

        public int Sum()
        {
            int sum = 0;
            for(int i = 0; i < _nums.Length; i++)
            {
                sum += _nums[i];
            }
            return sum;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            foreach(int i in _nums)
            {
                sb.Append(i.ToString());
                sb.Append(" ");
            }
            return sb.ToString();
        }

        public int IndexOf(int num)
        {
            for (int i = 0; i < _nums.Length; i++)
            {
                if (_nums[i] == num)
                {
                    return i; 
                }
            }
            return -1; 
        }

        public int LastIndexOf(int num)
        {
            for (int i = _nums.Length - 1; i >= 0; i--)
            {
                if (_nums[i] == num)
                {
                    return i; 
                }
            }
            return -1; 
        }

        public void Insert(int num,int index)
        {
            int[] array = new int[_nums.Length + 1];
            for(int i = 0; i <index; i++)
            {
                array[i] = _nums[i];
            }
            array[index] = num;
            for(int i = index; i < _nums.Length; i++)
            {
                array[i+ 1] = _nums[i];
            }
            _nums = array;
        }


        public float Average()
        {
            float sum = Sum();
            if (_nums.Length == 0)
            {
                Console.WriteLine("Sifira bolmek olmur");
                return -1;
            }
            return sum/ _nums.Length; 
        }
    }
}
