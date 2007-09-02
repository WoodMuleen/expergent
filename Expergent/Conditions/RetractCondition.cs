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

using Expergent.Terms;

namespace Expergent.Conditions
{
    ///<summary>A Retract Condition
    ///</summary>
    public class RetractCondition : RightHandSideCondition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetractCondition"/> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="attribute">The attribute.</param>
        /// <param name="value">The value.</param>
        public RetractCondition(Term id, Term attribute, Term value)
            : base("RetractCondition", ConditionType.Retract, id, attribute, value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetractCondition"/> class.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="id">The id.</param>
        /// <param name="attribute">The attribute.</param>
        /// <param name="value">The value.</param>
        public RetractCondition(string label, Term id, Term attribute, Term value)
            : base(label, ConditionType.Retract, id, attribute, value)
        {
        }
    }
}