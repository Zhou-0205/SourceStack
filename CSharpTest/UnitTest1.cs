using NewCsharplearn;
using NUnit.Framework;
using System.Collections.Generic;

namespace CSharpTest
{
    public class Tests
    {
        DoubleLinked<string> node1, node2, node3, node4, node5;
        [SetUp]
        public void Setup()
        {
            node1 = new DoubleLinked<string>() { Value = 1 };
            node2 = new DoubleLinked<string>() { Value = 2 };
            node3 = new DoubleLinked<string>() { Value = 3 };
            node4 = new DoubleLinked<string>() { Value = 4 };
            node5 = new DoubleLinked<string>() { Value = 5 };

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = null;

            node5.Previous = node4;
            node4.Previous = node3;
            node3.Previous = node2;
            node2.Previous = node1;
            node1.Previous = null;
        }
        [Test]
        public void InsertAfterTest()
        {
            //1 2 3 [6] 4 5
            DoubleLinked<string> node6 = new DoubleLinked<string>();
            node3.InsertAfter(node6);

            Assert.AreEqual(node6, node3.Next);
            Assert.AreEqual(node6, node4.Previous);
            Assert.AreEqual(node3, node6.Previous);
            Assert.AreEqual(node4, node6.Next);
        }
        [Test]
        public void InsertAfterTailTest()
        {
            //1 2 3 4 5 [6]
            DoubleLinked<string> node6 = new DoubleLinked<string>();
            node5.InsertAfter(node6);

            Assert.AreEqual(node6, node5.Next);
            Assert.AreEqual(node5, node6.Previous);
            Assert.IsNull(node6.Next);
        }
        [Test]
        public void InsertBeforeTest()
        {
            //1 2 3 [6] 4 5
            DoubleLinked<string> node6 = new DoubleLinked<string>();
            node4.InsertBefore(node6);

            Assert.AreEqual(node6, node4.Previous);
            Assert.AreEqual(node6, node3.Next);
            Assert.AreEqual(node4, node6.Next);
            Assert.AreEqual(node3, node6.Previous);
        }
        [Test]
        public void InsertBeforeHeadTest()
        {
            //[6] 1 2 3 4 5
            DoubleLinked<string> node6 = new DoubleLinked<string>();
            node1.InsertBefore(node6);

            Assert.AreEqual(node6, node1.Previous);
            Assert.AreEqual(node1, node6.Next);
            Assert.IsNull(node6.Previous);
        }
        [Test]
        public void DeleteHeadTest()
        {
            //[1] 2 3 4 5 
            node1.Delete();

            Assert.IsNull(node2.Previous);
            Assert.IsNull(node1.Next);
            Assert.IsNull(node1.Previous);
        }
        [Test]
        public void DeleteTailTest()
        {
            //1 2 3 4 [5]
            node5.Delete();

            Assert.IsNull(node4.Next);
            Assert.IsNull(node5.Previous);
            Assert.IsNull(node5.Next);
        }
        [Test]
        public void DeleteMiddleTest()
        {
            //1 2 [3] 4 5
            node3.Delete();

            Assert.AreEqual(node2, node4.Previous);
            Assert.AreEqual(node4, node2.Next);
            Assert.IsNull(node3.Previous);
            Assert.IsNull(node3.Next);
        }
        [Test]
        public void DeleteOnlyOneTest()
        {
            //[1] 2 3 4 5 
            node1.Delete();

            Assert.IsNull(node2.Previous);
            Assert.IsNull(node1.Next);
            Assert.IsNull(node1.Previous);

            //2 3 4 [5]
            node5.Delete();

            Assert.IsNull(node4.Next);
            Assert.IsNull(node5.Previous);
            Assert.IsNull(node5.Next);

            //2 [3] 4
            node3.Delete();

            Assert.AreEqual(node2, node4.Previous);
            Assert.AreEqual(node4, node2.Next);
            Assert.IsNull(node3.Previous);
            Assert.IsNull(node3.Next);

            //[2] 4
            node2.Delete();

            Assert.IsNull(node4.Previous);
            Assert.IsNull(node4.Next);
            Assert.IsNull(node2.Next);
            Assert.IsNull(node2.Previous);
        }
        [Test]
        public void Swap_1_2_Test()
        {
            //  [1] [2] 3 4 5
            //=>[2] [1] 3 4 5
            node1.Swap(node2);

            Assert.IsNull(node2.Previous);
            Assert.AreEqual(1, node2.Next.Value);
            Assert.AreEqual(2, node1.Previous.Value);
            Assert.AreEqual(3, node1.Next.Value);
            Assert.AreEqual(1, node3.Previous.Value);
        }
        [Test]
        public void Swap_1_3_Test()
        {
            //  [1] 2 [3] 4 5
            //=>[3] 2 [1] 4 5
            node1.Swap(node3);

            Assert.AreEqual(node2, node1.Previous);
            Assert.AreEqual(node4, node1.Next);
            Assert.AreEqual(node1, node4.Previous);
            Assert.AreEqual(node1, node2.Next);
            Assert.AreEqual(node3, node2.Previous);
            Assert.AreEqual(node2, node3.Next);
            Assert.IsNull(node3.Previous);
        }
        [Test]
        public void Swap_1_4_Test()
        {
            //  [1] 2 3 [4] 5
            //=>[4] 2 3 [1] 5
            node1.Swap(node4);

            Assert.AreEqual(node3, node1.Previous);
            Assert.AreEqual(node5, node1.Next);
            Assert.AreEqual(node1, node5.Previous);
            Assert.AreEqual(node1, node3.Next);
            Assert.AreEqual(node4, node2.Previous);
            Assert.AreEqual(node2, node4.Next);
            Assert.IsNull(node4.Previous);
        }
        [Test]
        public void Swap_1_5_Test()
        {
            //  [1] 2 3 4 [5]
            //=>[5] 2 3 4 [1]
            node1.Swap(node5);

            Assert.AreEqual(node1, node4.Next);
            Assert.AreEqual(node4, node1.Previous);
            Assert.IsNull(node1.Next);
            Assert.AreEqual(node2, node5.Next);
            Assert.AreEqual(node5, node2.Previous);
            Assert.IsNull(node5.Previous);
        }
        [Test]
        public void Swap_2_1_Test()
        {
            //  [1] [2] 3 4 5
            //=>[2] [1] 3 4 5
            node2.Swap(node1);

            Assert.AreEqual(node2, node1.Previous);
            Assert.AreEqual(node3, node1.Next);
            Assert.AreEqual(node1, node3.Previous);
            Assert.AreEqual(node1, node2.Next);
            Assert.IsNull(node2.Previous);
        }
        [Test]
        public void Swap_2_3_Test()
        {
            //  1 [2] [3] 4 5
            //=>1 [3] [2] 4 5
            node2.Swap(node3);

            Assert.AreEqual(node3, node2.Previous);
            Assert.AreEqual(node4, node2.Next);
            Assert.AreEqual(node2, node4.Previous);
            Assert.AreEqual(node2, node3.Next);
            Assert.AreEqual(node1, node3.Previous);
            Assert.AreEqual(node3, node1.Next);
        }
        [Test]
        public void Swap_2_4_Test()
        {
            //  1 [2] 3 [4] 5
            //=>1 [4] 3 [2] 5
            node2.Swap(node4);

            Assert.AreEqual(node3, node2.Previous);
            Assert.AreEqual(node5, node2.Next);
            Assert.AreEqual(node1, node4.Previous);
            Assert.AreEqual(node3, node4.Next);
            Assert.AreEqual(node4, node3.Previous);
            Assert.AreEqual(node2, node3.Next);
            Assert.AreEqual(node2, node5.Previous);
            Assert.AreEqual(node4, node1.Next);
        }
        [Test]
        public void Swap_2_5_Test()
        {
            //  1 [2] 3 4 [5]
            //=>1 [5] 3 4 [2]
            node2.Swap(node5);

            Assert.AreEqual(node4, node2.Previous);
            Assert.AreEqual(node2, node4.Next);
            Assert.IsNull(node2.Next);
            Assert.AreEqual(node1, node5.Previous);
            Assert.AreEqual(node3, node5.Next);
            Assert.AreEqual(node5, node3.Previous);
            Assert.AreEqual(node5, node1.Next);
        }
        [Test]
        public void Swap_3_1_Test()
        {
            //  [1] 2 [3] 4 5
            //=>[3] 2 [1] 4 5
            node3.Swap(node1);

            Assert.AreEqual(node2, node1.Previous);
            Assert.AreEqual(node4, node1.Next);
            Assert.AreEqual(node1, node4.Previous);
            Assert.AreEqual(node1, node2.Next);
            Assert.AreEqual(node3, node2.Previous);
            Assert.AreEqual(node2, node3.Next);
            Assert.IsNull(node3.Previous);
        }
        [Test]
        public void Swap_3_2_Test()
        {
            //  1 [2] [3] 4 5
            //=>1 [3] [2] 4 5
            node3.Swap(node2);

            Assert.AreEqual(node3, node2.Previous);
            Assert.AreEqual(node4, node2.Next);
            Assert.AreEqual(node2, node4.Previous);
            Assert.AreEqual(node2, node3.Next);
            Assert.AreEqual(node1, node3.Previous);
            Assert.AreEqual(node3, node1.Next);
        }
        [Test]
        public void Swap_3_4_Test()
        {
            //  1 2 [3] [4] 5
            //=>1 2 [4] [3] 5
            node3.Swap(node4);

            Assert.AreEqual(node3, node5.Previous);
            Assert.AreEqual(node5, node3.Next);
            Assert.AreEqual(node4, node3.Previous);
            Assert.AreEqual(node3, node4.Next);
            Assert.AreEqual(node2, node4.Previous);
            Assert.AreEqual(node4, node2.Next);
        }
        [Test]
        public void Swap_3_5_Test()
        {
            //  1 2 [3] 4 [5]
            //=>1 2 [5] 4 [3]
            node3.Swap(node5);

            Assert.AreEqual(node4, node3.Previous);
            Assert.IsNull(node3.Next);
            Assert.AreEqual(node5, node4.Previous);
            Assert.AreEqual(node3, node4.Next);
            Assert.AreEqual(node2, node5.Previous);
            Assert.AreEqual(node4, node5.Next);
            Assert.AreEqual(node5, node2.Next);
        }
        [Test]
        public void Swap_4_1_Test()
        {
            //  [1] 2 3 [4] 5
            //=>[4] 2 3 [1] 5
            node4.Swap(node1);

            Assert.AreEqual(node3, node1.Previous);
            Assert.AreEqual(node5, node1.Next);
            Assert.AreEqual(node1, node5.Previous);
            Assert.AreEqual(node1, node3.Next);
            Assert.AreEqual(node4, node2.Previous);
            Assert.AreEqual(node2, node4.Next);
            Assert.IsNull(node4.Previous);
        }
        [Test]
        public void Swap_4_2_Test()
        {
            //  1 [2] 3 [4] 5
            //=>1 [4] 3 [2] 5
            node4.Swap(node2);

            Assert.AreEqual(node3, node2.Previous);
            Assert.AreEqual(node5, node2.Next);
            Assert.AreEqual(node1, node4.Previous);
            Assert.AreEqual(node3, node4.Next);
            Assert.AreEqual(node4, node3.Previous);
            Assert.AreEqual(node2, node3.Next);
            Assert.AreEqual(node2, node5.Previous);
            Assert.AreEqual(node4, node1.Next);
        }
        [Test]
        public void Swap_4_3_Test()
        {
            //  1 2 [3] [4] 5
            //=>1 2 [4] [3] 5
            node4.Swap(node3);

            Assert.AreEqual(node3, node5.Previous);
            Assert.AreEqual(node5, node3.Next);
            Assert.AreEqual(node4, node3.Previous);
            Assert.AreEqual(node3, node4.Next);
            Assert.AreEqual(node2, node4.Previous);
            Assert.AreEqual(node4, node2.Next);
        }
        [Test]
        public void Swap_4_5_Test()
        {
            //  1 2 3 [4] [5]
            //=>1 2 3 [5] [4]
            node4.Swap(node5);

            Assert.AreEqual(node5, node4.Previous);
            Assert.IsNull(node4.Next);
            Assert.AreEqual(node3, node5.Previous);
            Assert.AreEqual(node4, node5.Next);
            Assert.AreEqual(node5, node3.Next);
        }
        [Test]
        public void Swap_5_1_Test()
        {
            //  [1] 2 3 4 [5]
            //=>[5] 2 3 4 [1]
            node5.Swap(node1);

            Assert.AreEqual(node1, node4.Next);
            Assert.AreEqual(node4, node1.Previous);
            Assert.IsNull(node1.Next);
            Assert.AreEqual(node2, node5.Next);
            Assert.AreEqual(node5, node2.Previous);
            Assert.IsNull(node5.Previous);
        }
        [Test]
        public void Swap_5_2_Test()
        {
            //  1 [2] 3 4 [5]
            //=>1 [5] 3 4 [2]
            node5.Swap(node2);

            Assert.AreEqual(node4, node2.Previous);
            Assert.AreEqual(node2, node4.Next);
            Assert.IsNull(node2.Next);
            Assert.AreEqual(node1, node5.Previous);
            Assert.AreEqual(node3, node5.Next);
            Assert.AreEqual(node5, node3.Previous);
            Assert.AreEqual(node5, node1.Next);
        }
        [Test]
        public void Swap_5_3_Test()
        {
            //  1 2 [3] 4 [5]
            //=>1 2 [5] 4 [3]
            node5.Swap(node3);

            Assert.AreEqual(node4, node3.Previous);
            Assert.IsNull(node3.Next);
            Assert.AreEqual(node5, node4.Previous);
            Assert.AreEqual(node3, node4.Next);
            Assert.AreEqual(node2, node5.Previous);
            Assert.AreEqual(node4, node5.Next);
            Assert.AreEqual(node5, node2.Next);
        }
        [Test]
        public void Swap_5_4_Test()
        {
            //  1 2 3 [4] [5]
            //=>1 2 3 [5] [4]
            node5.Swap(node4);

            Assert.AreEqual(node5, node4.Previous);
            Assert.IsNull(node4.Next);
            Assert.AreEqual(node3, node5.Previous);
            Assert.AreEqual(node4, node5.Next);
            Assert.AreEqual(node5, node3.Next);
        }
        [Test]
        public void ForeachTest()
        {
            IList<DoubleLinked<string>> nodes = new List<DoubleLinked<string>>();
            foreach (var item in node1)
            {
                nodes.Add(item);
            }
            //12345
            Assert.AreEqual(nodes.Count,5);

            Assert.AreEqual(node1.Value, nodes[0].Value);
            Assert.AreEqual(node2.Value, nodes[1].Value);
            Assert.AreEqual(node3.Value, nodes[2].Value);
            Assert.AreEqual(node4.Value, nodes[3].Value);
            Assert.AreEqual(node5.Value, nodes[4].Value);
        }
    }
}