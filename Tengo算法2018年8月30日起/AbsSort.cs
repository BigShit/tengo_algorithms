﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {


    /// <summary>
    /// 排序的抽象类，存放要排序的数组以及重置数组等基本方法
    /// </summary>
    public abstract class AbsSort {

        /// <summary>
        /// 要排序的数组
        /// </summary>
        public int[] arr = new int[] { 7, 9, 1, 8, 10, 4, 2, 5, 6, 3 };

        /// <summary>
        /// 重置数组
        /// </summary>
        public void Reset() {
            arr = new int[] { 7, 9, 1, 8, 10, 4, 2, 5, 6, 3 };
        }

    }
}
