﻿using System;
using System.Threading.Tasks;
using NumSharp.Backends;
using NumSharp.Utilities;

namespace NumSharp
{
    public partial class NumPyRandom
    {
        /// <summary>
        /// Draw samples from the geometric distribution.
        /// Bernoulli trials are experiments with one of two outcomes: success or failure(an example of such an experiment is flipping a coin). 
        /// The geometric distribution models the number of trials that must be run in order to achieve success.It is therefore supported on the positive integers, k = 1, 2, ....
        /// </summary>
        /// <param name="p">The probability of success of an individual trial.</param>
        /// <param name="dims">Output Shape</param>
        /// <returns></returns>
        public NDArray geometric(double p, params int[] dims)
        {
            var x = np.log(1 - np.random.uniform(0, 1, dims));
            return x / (Math.Log(p) + 1);
        }
    }
}
