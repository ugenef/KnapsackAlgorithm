﻿using System.Collections.Generic;
using KnapsackAlgorithm.Entities;

namespace KnapsackAlgorithm.Tests.Correctness
{
    public static class TestCases
    {
        public static TestCase FewExpensiveAndManyChipItems = new TestCase(5, new List<Item>
        {
            new Item(1, 15),
            new Item(5, 1),
            new Item(3, 10),
            new Item(3, 3),
            new Item(3, 4),
            new Item(4, 5)
        }, 25);

        public static TestCase OneExpensiveAndTwoChipItemsWithGreatestSumCost = new TestCase(6, new List<Item>
        {
            new Item(3, 2),
            new Item(4, 3),
            new Item(3, 2),
        }, 4);

        public static TestCase NoItemsWhenNotEnoughWeight = new TestCase(2, new List<Item>
        {
            new Item(3, 2),
            new Item(4, 3),
            new Item(3, 2),
        }, 0);

        public static TestCase SimpleTestCase = new TestCase(10, new List<Item>
        {
            new Item(5, 10),
            new Item(4, 40),
            new Item(6, 30),
            new Item(3, 50),
        }, 90);

        public static TestCase SimpleTestCase2 = new TestCase(10, new List<Item>
        {
        }, 0);
    }
}