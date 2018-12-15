using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

// author: Ruel B. Sucgang (.net software developer)
// desc: this is a reusable class to help us get the property name and value 

namespace App.Domain.Services
{
    public static class PropService
    {
        public static string GetMemberName<T>(Expression<Func<T>> memberExpression)
        {
            MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }

        public static string GetMemberType(dynamic obj)
        {
            return obj.GetType().ToString();
        }

    }
}
