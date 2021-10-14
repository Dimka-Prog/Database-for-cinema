using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class LinkedList
    {
        public class Node
        {
            public uint data { get; set; }
            public Node pNext { get; set;}
            public Node pPrev { get; set; }
            public Node[] mass = new Node[100];

            public Node(uint data, Node pNext = null, Node pPrev = null)
            {
                this.data = data;
                this.pNext = pNext;
                this.pPrev = pPrev;
            }

            public Node(Node pNext = null)
            {
                this.pNext = pNext;
            }
        }

        public class Films 
        {
            public string NameFilm { get; set; }
            public uint Number { get; set; }

            public Films(string NameFilm, uint Number)
            {
                this.NameFilm = NameFilm;
                this.Number = Number;
            }
        }

        public class Tree
        {
            Films key { get; set; }
            byte height { get; set; }
            Tree left { get; set; }
            Tree right { get; set; }

            public Tree(Films key)
            {
                this.key = key;
                left = right = null;
                height = 1;
            }

            public Tree()
            {
                
            }

            /// <summary>
            /// Вставляет ключ в дерево
            /// </summary>
            /// <param name="elemtree"></param>
            /// <param name="key"></param>
            /// <returns></returns>
            public Tree Insert(Tree elemtree, Films key)
            {
                if (elemtree == null)
                {
                    elemtree = new Tree(key);
                    return elemtree;
                }
                else if (elemtree.height == 0)
                {
                    elemtree = null;
                    elemtree = new Tree(key);
                    return elemtree;
                }

                if (key.Number < elemtree.key.Number)
                    elemtree.left = Insert(elemtree.left, key);
                else
                    elemtree.right = Insert(elemtree.right, key);
                return Balance(elemtree);
            }

            private Tree Balance(Tree elemtree)
            {
                FixHeight(elemtree);
                if (ValueNode(elemtree) == 2)
                {
                    if (ValueNode(elemtree.right) < 0)
                        elemtree.right = RotateRight(elemtree.right);
                    return RotateLeft(elemtree);
                }
                if (ValueNode(elemtree) == -2)
                {
                    if (ValueNode(elemtree.left) > 0)
                        elemtree.left = RotateLeft(elemtree.left);
                    return RotateRight(elemtree);
                }
                return elemtree;
            }

            private void FixHeight(Tree elemtree)
            {
                byte HeightLeft = Height(elemtree.left);
                byte HeightRight = Height(elemtree.right);
                elemtree.height = (byte)((HeightLeft > HeightRight ? HeightLeft : HeightRight) + 1);
            }

            private byte Height(Tree elemtree)
            {
                if (elemtree == null) return 0;
                else if (elemtree.height != 0) return elemtree.height;

                return 0;
            }

            private int ValueNode(Tree elemtree) 
            {
                return Height(elemtree.right) - Height(elemtree.left);
            }

            private Tree RotateRight(Tree elemtree)
            {
                Tree current = elemtree.left;
                elemtree.left = current.right;
                current.right = elemtree;

                FixHeight(elemtree);
                FixHeight(current);

                return current;
            }

            private Tree RotateLeft(Tree elemtree) 
            {
                Tree current = elemtree.right;
                elemtree.right = current.left;
                current.left = elemtree;

                FixHeight(elemtree);
                FixHeight(current);

                return current;
            }

            /// <summary>
            /// Осуществляет поиск ключа по дереву
            /// </summary>
            /// <param name="elemtree"></param>
            /// <param name="key"></param>
            /// <param name="film"></param>
            /// <returns></returns>
            public string Find(Tree elemtree, Films key, string film = "")
            {
                if (elemtree == null || elemtree.key == null) return "";

                if (elemtree.key.Number < key.Number)
                    return Find(elemtree.right, key);
                else if (elemtree.key.Number > key.Number)
                    return Find(elemtree.left, key);
                else
                    film = elemtree.key.NameFilm;
                    return film;
            }

            /// <summary>
            /// Удаляет ключ из дерева
            /// </summary>
            /// <param name="elemtree"></param>
            /// <param name="key"></param>
            /// <returns></returns>
            public Tree Remove(Tree elemtree, Films key)
            {
                if (key.Number < elemtree.key.Number)
                    elemtree.left = Remove(elemtree.left, key);
                else if (key.Number > elemtree.key.Number)
                    elemtree.right = Remove(elemtree.right, key);
                else 
                {
                    Tree nodeleft = elemtree.left;
                    Tree noderight = elemtree.right;
                    elemtree = null;
                    if (nodeleft == null) return noderight;
                    Tree max = FindMax(nodeleft);
                    max.left = RemoveMax(nodeleft);
                    max.right = noderight;
                    return Balance(max);
                }
                return Balance(elemtree);
            }

            private Tree FindMax(Tree elemtree) 
            {
                if (elemtree.right != null) return FindMax(elemtree.right);
                else return elemtree;
            }

            private Tree RemoveMax(Tree elemtree)
            {
                if (elemtree.right == null)
                    return elemtree.left;
                elemtree.right = RemoveMax(elemtree.right);
                return Balance(elemtree);
            }
        }

        public class List: Node
        {
            Node head { get; set; }
            Node tail { get; set; }
            
            /// <summary>
            /// Добавляет элемент в список
            /// </summary>
            /// <param name="value"></param>
            public void AddPlace(in uint value, in uint index)
            {
                if (mass[index] == null)
                {
                    head = new Node(value);
                    head.pNext = head;
                    head.pPrev = head;
                    mass[index] = new Node(head);
                }
                else
                {
                    head = mass[index].pNext;
                    head.pPrev = new Node(value, pPrev: head.pPrev);
                    Node current = head.pPrev;
                    current.pNext = head;
                    head = head.pPrev;
                    tail = head.pPrev;
                    tail.pNext = head;
                    mass[index].pNext = head;
                }
            }

            /// <summary>
            /// Удаляет элемент из списка
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public void DeletePlace(in uint value, in uint index)
            {
                head = mass[index].pNext;
                if (head.pNext == head)
                {
                    mass[index] = null;
                }
                else
                {
                    tail = head.pPrev;
                    Node current = head.pNext;
                    if (head.data == value)
                    {
                        current.pPrev = head.pPrev;
                        tail.pNext = current;
                        head = current;
                        mass[index].pNext = head;
                    }
                    else if (tail.data == value)
                    {
                        current = tail.pPrev;
                        current.pNext = head;
                        head.pPrev = current;
                        tail = current;
                    }
                    else
                    {
                        while (current.data != value)
                        {
                            current = current.pNext;
                        }
                        tail = current.pPrev;
                        tail.pNext = current.pNext;
                        tail = current.pNext;
                        tail.pPrev = current.pPrev;
                    }
                }
            }

            /// <summary>
            /// Проверяет добавляемый в список или удаляемый из списка элемент на существование
            /// </summary>
            /// <param name="value"></param>
            /// <param name="index"></param>
            /// <returns></returns>
            public bool CheckPlace(in uint value, in uint index)
            {
                if (mass[index] == null) return true;
                else
                {
                    head = mass[index].pNext;
                    tail = head.pPrev;
                    if ((head.data == value) || (tail.data == value)) return false;
                    
                    Node current = head.pNext;
                    while (current.pNext != head)
                    {
                        if (current.data == value) return false;

                        current = current.pNext;
                    }
                    return true;
                }
            }
        }
    }
}
