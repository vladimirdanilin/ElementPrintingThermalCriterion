using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ElementPrinting.Placement;

namespace ElementPrinting
{
    public class Fitness
    {
        public Fitness()
        {

        }

        public double Count(List<Element> listOfElements, double[,] adjmatrix, double[,] heatmatrix, List<Element> elementsExtra)
        { //Подсчет значения функции пригодности каждой особи

            FindCloseElements(listOfElements, adjmatrix);
            double Sum = 0;
            double Pi = 3.1415;
            double с0 = 5.67;

            for (int i = 0; i < Math.Sqrt(adjmatrix.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(adjmatrix.Length); j++)
                {
                    if ((i != j) && (listOfElements[i].CloseElements.Contains(j)))
                    {
                        double x1 = 0; //X координата первого элемента
                        double y1 = 0; //Y координата первого элемента
                        double w1 = 0; //Ширина первого элемента
                        double h1 = 0; //Высота первого элемента
                        double x2 = 0; //X координата второго элемента
                        double y2 = 0; //Y координата второго элемента
                        x1 = listOfElements[i].position.x + listOfElements[i].width / 2;
                        y1 = listOfElements[i].position.y + listOfElements[i].height / 2;
                        w1 = listOfElements[i].width;
                        h1 = listOfElements[i].height;
                        x2 = listOfElements[j].position.x + listOfElements[j].width / 2;
                        y2 = listOfElements[j].position.y + listOfElements[j].height / 2;

                        double Length = Math.Sqrt(Math.Pow((listOfElements[i].position.x + (listOfElements[i].width / 2)) - (listOfElements[j].position.x + (listOfElements[j].width / 2)), 2) + Math.Pow((listOfElements[i].position.y + (listOfElements[i].height / 2)) - (listOfElements[j].position.y + (listOfElements[j].height / 2)), 2)) * 0.001;
                        double angleOfVisibility = (FindAngle(listOfElements[i].position.x + listOfElements[i].width / 2, listOfElements[i].position.y + listOfElements[i].height / 2, listOfElements[i].width, listOfElements[i].height, listOfElements[j].position.x + listOfElements[j].width / 2, listOfElements[j].position.y + listOfElements[j].height / 2) *
                            FindAngle(listOfElements[j].position.x + listOfElements[j].width / 2, listOfElements[j].position.y + listOfElements[j].height / 2, listOfElements[j].width, listOfElements[j].height, listOfElements[i].position.x + listOfElements[i].width / 2, listOfElements[i].position.y + listOfElements[i].height / 2)) / (Pi * Math.Pow(Length, 2));

                        double AreaOfHeatingSurface = 0;
                        if ((FindOrientation(x1, y1, x1 - w1 / 2, y1 + h1 / 2, x2, y2) && FindOrientation(x1, y1, x1 + w1 / 2, y1 + h1 / 2, x2, y2)) ||
                            ((FindOrientation(x1, y1, x1 - w1 / 2, y1 + h1 / 2, x2, y2) == false) && (FindOrientation(x1, y1, x1 + w1 / 2, y1 + h1 / 2, x2, y2) == false)))
                        {
                            AreaOfHeatingSurface = listOfElements[i].width * listOfElements[i].thickness;
                        }
                        else
                        {
                            AreaOfHeatingSurface = listOfElements[i].height * listOfElements[i].thickness;
                        }
                        double Area = AreaOfHeatingSurface * 0.0001;
                        int index1 = elementsExtra.FindIndex(x => x == listOfElements[i]);
                        int index2 = elementsExtra.FindIndex(x => x == listOfElements[j]);
                        Sum += с0 * Area * Math.Pow(((heatmatrix[i, 0] - heatmatrix[j, 0]) / 100), 4) * angleOfVisibility;
                    }

                }
            }
            Sum = Math.Round(Sum, 4);

            return Sum;

        }

        private void FindCloseElements(List<Element> listOfElements, double[,] adjmatrix)
        {
            double Length = 0;
            double[] LengthArray;
            for (int i = 0; i < Math.Sqrt(adjmatrix.Length); i++)
            {
                LengthArray = new double[listOfElements.Count];
                for (int j = 0; j < Math.Sqrt(adjmatrix.Length); j++)
                {
                    if ((i != j))
                    {
                        Length = Math.Sqrt(Math.Pow((listOfElements[i].position.x + (listOfElements[i].width / 2)) -
                            (listOfElements[j].position.x + (listOfElements[j].width / 2)), 2) +
                            Math.Pow((listOfElements[i].position.y + (listOfElements[i].height / 2)) -
                            (listOfElements[j].position.y + (listOfElements[j].height / 2)), 2));
                        LengthArray[j] = Length;
                        LengthArray[i] = int.MaxValue; //Расстояние от элемента до самого себя максимально
                    }

                }

                for (int j = 0; j < 4; j++)
                {
                    int m = Array.IndexOf(LengthArray, LengthArray.Min());
                    LengthArray[m] = int.MaxValue;
                    listOfElements[i].CloseElements[j] = m;
                }

            }
        }


        //Расчет косинусов углов
        private double FindAngle(double x1, double y1, double w1, double h1, double x2, double y2)
        {
            if ((FindOrientation(x1, y1, x1 - w1 / 2, y1 + h1 / 2, x2, y2) && FindOrientation(x1, y1, x1 + w1 / 2, y1 + h1 / 2, x2, y2)) ||
                ((FindOrientation(x1, y1, x1 - w1 / 2, y1 + h1 / 2, x2, y2) == false) && (FindOrientation(x1, y1, x1 + w1 / 2, y1 + h1 / 2, x2, y2) == false)))
            {
                double vectx = Math.Abs(x2 - x1);
                double vecty = Math.Abs(y2 - y1);
                double normx = 0; //Задаем вектор нормали. В данном случае он сонаправлен с осью ординат
                double normy = 5;
                double skalar = vectx * normx + vecty * normy;
                double cosAlpha = skalar / (Math.Sqrt(Math.Pow(vectx, 2) + Math.Pow(vecty, 2)) * Math.Sqrt(Math.Pow(normx, 2) + Math.Pow(normy, 2)));
                cosAlpha = Math.Round(cosAlpha, 4);
                return cosAlpha;
            }
            else
            {
                double vectx = Math.Abs(x2 - x1);
                double vecty = Math.Abs(y2 - y1);
                double normx = 5; //Задаем вектор нормали. В данном случае он сонаправлен с осью абсцисс
                double normy = 0;
                double skalar = vectx * normx + vecty * normy;
                double cosAlpha = skalar / (Math.Sqrt(Math.Pow(vectx, 2) + Math.Pow(vecty, 2)) * Math.Sqrt(Math.Pow(normx, 2) + Math.Pow(normy, 2)));
                cosAlpha = Math.Round(cosAlpha, 4);
                return cosAlpha;
            }

        }

        //Выражаем критерий через каноническое уравнение прямой на плоскости
        private bool FindOrientation(double xOfPoint1Border, double yOfPoint1Border, double xOfPoint2Border, double yOfPoint2Border, double xOfElement, double yOfElement)
        {
            double Criteria = ((yOfElement - yOfPoint1Border) / (yOfPoint2Border - yOfPoint1Border)) - ((xOfElement - xOfPoint1Border) / (xOfPoint2Border - xOfPoint1Border));
            if (Criteria > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
