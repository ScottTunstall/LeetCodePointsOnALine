﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace LeetCodeMaxPointsOnALine
{
    class Program
    {

        static void Main(string[] args)
        {

            int[][] points;
            int count;
            var sol = new Solution();

            points = new int[][]
            {
                new[] {1, 1},
                new[] {1, 1},
                new[] {1, 1}
            };

            count = sol.MaxPoints(points);
            Debug.Assert(count == 3);


            //var points = new int[][]
            //{
            //    new[] {1, 1},
            //    new[] {2, 2},
            //    new[] {3,3}
            //};

            //var count = sol.MaxPoints(points);
            //Debug.Assert(count == 3);

            //points = new int[][]
            //{
            //    new[] {1, 1},
            //    new[] {3, 2},
            //    new[] {5,3},
            //    new[] {4,1},
            //    new[] {2,3},
            //    new[] {1,4},
            //};

            //count = sol.MaxPoints(points);
            //Debug.Assert(count==4);


            points = new int[][]
            {
                new[] {0, 0},
                new[] {0, 0},
            };

            count = sol.MaxPoints(points);
            Debug.Assert(count == 2);

            Console.WriteLine(count);
        }
    }
}
