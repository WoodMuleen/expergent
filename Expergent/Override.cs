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

namespace Expergent
{
    /// <summary>
    /// Defines an Override winner and loser
    /// </summary>
    public class Override
    {
        private string _winner;
        private string _loser;
        private string _label;

        /// <summary>
        /// Initializes a new instance of the <see cref="Override"/> class.
        /// </summary>
        public Override()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Override"/> class.
        /// </summary>
        /// <param name="winner">The winner.</param>
        /// <param name="loser">The loser.</param>
        public Override(string winner, string loser)
        {
            _winner = winner;
            _loser = loser;
        }

        /// <summary>
        /// Gets or sets the winner.
        /// </summary>
        /// <value>The winner.</value>
        public string Winner
        {
            get { return _winner; }
            set { _winner = value; }
        }

        /// <summary>
        /// Gets or sets the loser.
        /// </summary>
        /// <value>The loser.</value>
        public string Loser
        {
            get { return _loser; }
            set { _loser = value; }
        }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
    }
}