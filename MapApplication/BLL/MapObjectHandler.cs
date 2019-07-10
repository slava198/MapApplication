using GMap.NET;
using MapApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MapApplication.BLL
{
    public static class MapObjectHandler
    {
        static readonly double oneDegreeLatitude = 111.111;
        static readonly double epsilon = 0.001;


        public static double Distantion(PointLatLng A, PointLatLng B)
        {
            double oneDegreeLongitude = oneDegreeLatitude * Math.Cos((Math.PI * A.Lat) / 180);
            double dx = (B.Lat - A.Lat) * oneDegreeLatitude;
            double dy = (B.Lng - A.Lng) * oneDegreeLongitude;
            var result = Math.Sqrt(dx * dx + dy * dy);
            return result;
        }


        public static CloserDepartmentInfo FindCloserDepartment(PointLatLng basePoint, List<Departmen> departmens)
        {
            if (departmens == null || departmens.Count == 0)
            {
                return null;
            }

            var tempDep = departmens.First();
            double minDist = Distantion(tempDep.GetPosition(), basePoint);
            double tempDist;

            foreach (var depItem in departmens)
            {
                tempDist = Distantion(basePoint, depItem.GetPosition());
                if (tempDist < minDist)
                {
                    minDist = tempDist;
                    tempDep = depItem;
                }
            }
            return new CloserDepartmentInfo() { Distantion = minDist, DepartmentPosition = tempDep.GetPosition() };
        }


        public static CloserDepartmentInfo FindCloserBestCourseDepartment(PointLatLng basePoint, List<Bank> banks, List<Departmen> departmens, OperationType operation, CurrencyType currency)
        {
            if (departmens == null || departmens.Count == 0)
            {
                return null;
            }
            List<Departmen> bestCourceDeps = new List<Departmen>();

            if (operation == OperationType.Buy)
            {
                double minCourse = 0;
                if (currency == CurrencyType.USD)
                {
                    minCourse = banks.First().currentCourse.USD.Buy;
                    foreach (Bank bank in banks)
                    {
                        if (minCourse > bank.currentCourse.USD.Buy)
                        {
                            minCourse = bank.currentCourse.USD.Buy;
                        }
                    }
                    foreach (Bank bank in banks)
                    {
                        if (Math.Abs(bank.currentCourse.USD.Buy - minCourse) < epsilon)
                        {
                            bank.departmens.ForEach(d => bestCourceDeps.Add(d));
                        }
                    }
                }
                else if (currency == CurrencyType.EUR)
                {
                    minCourse = banks.First().currentCourse.EUR.Buy;
                    foreach (Bank bank in banks)
                    {
                        if (minCourse > bank.currentCourse.EUR.Buy)
                        {
                            minCourse = bank.currentCourse.EUR.Buy;
                        }
                    }
                    foreach (Bank bank in banks)
                    {
                        if (Math.Abs(bank.currentCourse.EUR.Buy - minCourse) < epsilon)
                        {
                            bank.departmens.ForEach(d => bestCourceDeps.Add(d));
                        }
                    }
                }
                else if (currency == CurrencyType.RUR)
                {
                    minCourse = banks.First().currentCourse.RUR.Buy;
                    foreach (Bank bank in banks)
                    {
                        if (minCourse > bank.currentCourse.RUR.Buy)
                        {
                            minCourse = bank.currentCourse.RUR.Buy;
                        }
                    }
                    foreach (Bank bank in banks)
                    {
                        if (Math.Abs(bank.currentCourse.RUR.Buy - minCourse) < epsilon)
                        {
                            bank.departmens.ForEach(d => bestCourceDeps.Add(d));
                        }
                    }
                }
            }
            //----------------------------------
            else if (operation == OperationType.Sell)
            {
                double maxCourse = 0;
                if (currency == CurrencyType.USD)
                {
                    maxCourse = banks.First().currentCourse.USD.Sell;
                    foreach (Bank bank in banks)
                    {
                        if (maxCourse < bank.currentCourse.USD.Sell)
                        {
                            maxCourse = bank.currentCourse.USD.Sell;
                        }
                    }
                    foreach (Bank bank in banks)
                    {
                        if (Math.Abs(bank.currentCourse.USD.Sell - maxCourse) < epsilon)
                        {
                            bank.departmens.ForEach(d => bestCourceDeps.Add(d));
                        }
                    }
                }
                else if (currency == CurrencyType.EUR)
                {
                    maxCourse = banks.First().currentCourse.EUR.Sell;
                    foreach (Bank bank in banks)
                    {
                        if (maxCourse < bank.currentCourse.EUR.Sell)
                        {
                            maxCourse = bank.currentCourse.EUR.Sell;
                        }
                    }
                    foreach (Bank bank in banks)
                    {
                        if (Math.Abs(bank.currentCourse.EUR.Sell - maxCourse) < epsilon)
                        {
                            bank.departmens.ForEach(d => bestCourceDeps.Add(d));
                        }
                    }
                }
                else if (currency == CurrencyType.RUR)
                {
                    maxCourse = banks.First().currentCourse.RUR.Sell;
                    foreach (Bank bank in banks)
                    {
                        if (maxCourse < bank.currentCourse.RUR.Sell)
                        {
                            maxCourse = bank.currentCourse.RUR.Sell;
                        }
                    }
                    foreach (Bank bank in banks)
                    {
                        if (Math.Abs(bank.currentCourse.RUR.Sell - maxCourse) < epsilon)
                        {
                            bank.departmens.ForEach(d => bestCourceDeps.Add(d));
                        }
                    }
                }
            }
            return FindCloserDepartment(basePoint, bestCourceDeps);
        }
    }
}
