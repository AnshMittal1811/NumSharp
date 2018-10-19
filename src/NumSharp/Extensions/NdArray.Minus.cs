﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumSharp.Extensions
{
    public static partial class NDArrayExtensions
    {
        public static NDArray<NDArray<double>> Minus(this NDArray<NDArray<double>> np, double minus)
        {
            for(int row = 0; row < np.Length; row++)
            {
                for(int col = 0; col < np[row].Length; col++)
                {
                    np[row][col] -= minus;
                }
            }

            return np;
        }
    }
}