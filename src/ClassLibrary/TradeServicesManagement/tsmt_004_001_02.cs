
//                                      ______    ____  
//                                     |____  | "|__  | 
//                                      _   | |     | | 
//                                     | |  | |   __| | 
//                                     |_|  |_|  |_____| 
//
//  --------------------------------------------------- 
// |     _   ____     ___     ___    ____    ____      |
// |    (_) |___ \   / _ \   / _ \  |___ \  |___ \     |
// |    | |   __) | | | | | | | | |   __) |   __) |    |
// |    | |  / __/  | |_| | | |_| |  / __/   / __/     |
// |    |_| |_____|  \___/   \___/  |_____| |_____|    |
// |                                                   |
// |    AN ISO 20022 OPEN-SOURCE .NET CLASS LIBRARY    |
// |            FOR MESSAGING APPLICATIONS             |
// |                                                   |
// |        Copyright (C) 2008 Mauricio Leventer       |
// |                mleventer@i20022.com               |
// |                                                   |
//  ---------------------------------------------------
//
// L I C E N S E                                         
//                                                       
// This program is free software; you can redistribute it
// and/or modify it under the terms of the GNU General   
// Public License as published by the Free Software      
// Foundation; either version 2 of the License, or (at   
// your option) any later version.                       
//                                                       
// This program is distributed in the hope that it will  
// be useful, but WITHOUT ANY WARRANTY; without even the 
// implied warranty of MERCHANTABILITY or FITNESS FOR A  
// PARTICULAR PURPOSE. See the GNU General Public License
// for more details.                                     
//                                                       
// You should have received a copy of the GNU General    
// Public License along with this program; if not, write 
// to the Free Software Foundation, Inc.,                
// 59 Temple Place, Suite 330, Boston, MA                
// 02111-1307 USA.                                       
//                                                       
//
using System;
using System.Diagnostics;
using System.Xml.Serialization;


namespace i20022.tsmt00400102
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.004.001.02 name ActivityReportSetUpRequestV02 from Trade Services Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.004.001.02" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.004.001.02", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>ActvtyRptSetUpReq</b> (Activity Report Set Up Request) of type ActivityReportSetUpRequestV02.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ActivityReportSetUpRequestV02 ActvtyRptSetUpReq;
    }

    /// <summary>
    /// Class <b>ActivityReportSetUpRequestV02</b> (Activity Report Set Up Request V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.004.001.02" )]
    public class ActivityReportSetUpRequestV02
    {

        /// <summary>
        /// Element <b>ReqId</b> (Request Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 ReqId;

        /// <summary>
        /// Element <b>UTCOffset</b> (UTCOffset) of type UTCOffset1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public UTCOffset1 UTCOffset;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.004.001.02" )]
    public class MessageIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime CreDtTm;
    }

    /// <summary>
    /// Class <b>UTCOffset1</b> (UTCOffset 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.004.001.02" )]
    public class UTCOffset1
    {

        /// <summary>
        /// Element <b>Sgn</b> (Sign) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public bool Sgn;

        /// <summary>
        /// Element <b>NbOfHrs</b> (Number Of Hours) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "time", Order = 1 )]
        public System.DateTime NbOfHrs;
    }
}
