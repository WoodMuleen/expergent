#region license

// Copyright (c) 2007, Michael A. Rose (The Universal Sun, Inc.) (michael@theuniversalsun.com)
// All rights reserved.
//
// This file is part of Expergent.
//
// Expergent is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License (GPL) as published by
// the Free Software Foundation; either version 3 of the License, or
// (at your option) any later version.
// 
// Expergent is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this distribution; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Expergent.Terms
{
    ///<summary>
    ///</summary>
    ///<typeparam name="T"></typeparam>
    public class GenericListTerm<T> : ListTerm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericListTerm&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="obj">The obj.</param>
        public GenericListTerm(ICollection<T> obj) : base(null)
        {
            _termType = TermType.List;
            _value = obj;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public new ICollection<T> Value
        {
            get { return (ICollection<T>) _value; }
            set { _value = value; }
        }

        /// <summary>
        /// Gets the type of the member.
        /// </summary>
        /// <value>The type of the member.</value>
        public Type MemberType
        {
            get { return typeof (T); }
        }

        /// <summary>
        /// Copies this instance.
        /// </summary>
        /// <returns></returns>
        public override Term Copy()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Toes the string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("list(");
            bool prePend = false;
            foreach (T o in (ICollection<T>) _value)
            {
                if (prePend)
                {
                    sb.Append(", ").Append(o.ToString());
                }
                else
                {
                    sb.Append(o.ToString());
                    prePend = true;
                }
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}