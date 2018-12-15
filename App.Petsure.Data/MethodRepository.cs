using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using App.Domain.Entities;
using App.Domain.Interfaces.Repositories;
using App.Domain.Services;

namespace App.Petsure.Data
{
    public class MethodRepository : iMethodRepository
    {

        public List<ListProperties>  GetDuplicates(List<MethodEn> obj1, List<MethodEn> obj2)
        {
            //merge lists
            List<MethodEn> obj = new List<MethodEn>();
            foreach (var item in obj1.Distinct().ToList())
            {
                obj.Add(new MethodEn
                {
                    Param1 = item.Param1
                });
            }
            foreach (var item in obj2.Distinct().ToList())
            {
                obj.Add(new MethodEn
                {
                    Param1 = item.Param1
                });
            }

            //get only duplicates
            var dup3 =
                from p in obj
                group p by p.Param1 into g
                where g.Count() > 1
                select g.ToList();
            
            //get distinct records (filter)
            List<MethodEn> distinctList = new List<MethodEn>();
            foreach (var item in dup3.Distinct().ToList())
            {
                distinctList.Add(new MethodEn
                {
                    Param1 = item[0].Param1
                });
            }

            //store the property name and its value in an entity
            var resultentity = new PropetiesEn();
            List<ListProperties> enList = new List<ListProperties>();
            foreach (var item in dup3.Distinct().ToList())
            {
                    resultentity.ParameterName = PropService.GetMemberName(() => item[0].Param1);
                    resultentity.ParameterValue = item[0].Param1.ToString();
                    //resultentity.ParameterType = PropService.GetMemberType(item[0].Param1);
                     //add to list
                    enList.Add(new ListProperties(resultentity.ParameterName.ToString(),
                    resultentity.ParameterValue.ToString(),""));
            }

            // return distinct records 
            //return distinctList.Distinct().ToList(); 
            return enList.Distinct().ToList();

        }

        public string CompareObjects(MethodEn obj1, MethodEn obj2)
        {
            string strResult = string.Empty;

            var resultentity = new PropetiesEn();
            List<ListProperties> enList = new List<ListProperties>();

            //set the values for the parameer 1
            resultentity.ParameterName = PropService.GetMemberName(() => obj1.Param1);
            resultentity.ParameterValue = obj1.Param1.ToString();
            resultentity.ParameterType = PropService.GetMemberType(obj1.Param1);
            //add to list
            enList.Add(new ListProperties(resultentity.ParameterName.ToString(),
            resultentity.ParameterValue.ToString(), resultentity.ParameterType.ToString()));

             //set the values for the parameer 1
            resultentity.ParameterName = PropService.GetMemberName(() => obj2.Param1);
            resultentity.ParameterValue = obj2.Param1.ToString();
            resultentity.ParameterType = PropService.GetMemberType(obj2.Param1);
            //add to list
            enList.Add(new ListProperties(resultentity.ParameterName.ToString(),
            resultentity.ParameterValue.ToString(), resultentity.ParameterType.ToString()));


            // return value
            return string.Concat(
                 string.Format(enList[0]._paramname + " Value is {0} Type is {1} ",
                        enList[0]._paramvalue, enList[0]._paramtype),
                        System.Environment.NewLine,
                string.Format(enList[1]._paramname + " Value is {0} Type is {1} ",
                        enList[1]._paramvalue, enList[1]._paramtype),
                        System.Environment.NewLine
               );
        }


    }
}
