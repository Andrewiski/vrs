﻿// Copyright © 2010 onwards, Andrew Whewell
// All rights reserved.
//
// Redistribution and use of this software in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
//    * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//    * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//    * Neither the name of the author nor the names of the program's contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE AUTHORS OF THE SOFTWARE BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualRadar.Interface.Database
{
    /// <summary>
    /// An object that holds the content of a record from the DBHistory table in the BaseStation database.
    /// </summary>
    public class BaseStationDBHistory
    {
        /// <summary>
        /// Gets or sets the unique identifier of the record in the database.
        /// </summary>
        public int DBHistoryID { get; set; }

        /// <summary>
        /// Gets or sets the time that the record was created or modified.
        /// </summary>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Gets or sets a mandatory 100 character description of the record.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets a value indicating that this record describes the creation of the database by the
        /// official Kinetic BaseStation application.
        /// </summary>
        public bool IsCreationOfDatabaseByBaseStation
        {
            get { return "Database autocreated by Snoopy".Equals(Description, StringComparison.OrdinalIgnoreCase); }
        }

        /// <summary>
        /// Gets a value indicating that this record describes the creation of the database by Virtual
        /// Radar Server. Note that in normal operation the database will never be created by VRS, the
        /// user must install an optional plugin and explicitly enable it to cause this to happen.
        /// </summary>
        public bool IsCreationOfDatabaseByVirtualRadarServer
        {
            get { return "Database autocreated by Virtual Radar Server".Equals(Description, StringComparison.OrdinalIgnoreCase); }
        }
    }
}
