using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementPrinting
{
    public class Placement
    {
        public Placement()
        {

        }
        public class Node
        {
            public Node right;
            public Node down;
            public double x;
            public double y;
            public double width;
            public double height;
            public bool used;
        }

        public List<Element> Elements = new List<Element>();
        public List<Element> ElementsExtra = new List<Element>(); //Хранит исходный порядок элементов

        public class Element
        {
            public double height;
            public double width;
            public double thickness;
            public int[] CloseElements = new int[4];
            public Node position;
        }

        private Node root;

        public void PackageStart(double[,] elementSize, int[] sequenceOfElements, double PCBwidth, double PCBheight)
        {
            Elements = new List<Element>();

            for (int i = 0; i < elementSize.Length / 3; i++)
            {
                Element element = new Element { width = elementSize[i, 0], height = elementSize[i, 1], thickness = elementSize[i, 2] };
                Elements.Add(element);
            }

            ElementsExtra.AddRange(Elements);

            for (int i = 0; i < sequenceOfElements.Length; i++)
            {
                Elements[i] = ElementsExtra[sequenceOfElements[i]];
            }

            Pack(PCBwidth, PCBheight);
        }

        private void Pack(double PCBwidth, double PCBheight)
        {
            root = new Node { width = PCBwidth, height = PCBheight };

            foreach (var element in Elements)
            {
                var node = SearchForNode(root, element.width, element.height); //Проверяем, можно ли в root вместить элемент
                if (node != null)
                {
                    element.position = GetSpace(node, element.width, element.height); //Определение свободного пространства для последующего размещения элементов
                }
                else
                {
                    element.position = new Node { x = PCBwidth + 10, y = PCBheight + 10 };
                }
            }
        }

        private Node SearchForNode(Node root, double ewidth, double eheight) //Поиск свободного пространства для размещения элемента
        {
            if (root.used)
            {
                var nextNode = SearchForNode(root.right, ewidth, eheight);

                if (nextNode == null)
                {
                    nextNode = SearchForNode(root.down, ewidth, eheight);
                }

                return nextNode;
            }
            else if (ewidth <= root.width && eheight <= root.height)
            {
                return root;
            }
            else
            {
                return null;
            }
        }

        private Node GetSpace(Node currentNode, double ewidth, double eheight) //Определение пространства для размещения последующих элементов
        {
            currentNode.used = true;
            currentNode.down = new Node { x = currentNode.x, y = currentNode.y + eheight, width = currentNode.width, height = currentNode.height - eheight };
            currentNode.right = new Node { x = currentNode.x + ewidth, y = currentNode.y, width = currentNode.width - ewidth, height = eheight };
            return currentNode;
        }
    }
}
