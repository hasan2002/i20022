
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


namespace i20022.tsmt04800101
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.048.001.01 name SpecialNotificationV01 from Trade Services Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>SpclNtfctn</b> (Spcl Notification) of type SpecialNotificationV01.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SpecialNotificationV01 SpclNtfctn;
    }

    /// <summary>
    /// Class <b>SpecialNotificationV01</b> (Special Notification V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
    public class SpecialNotificationV01
    {

        /// <summary>
        /// Element <b>NtfctnId</b> (Notification Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 NtfctnId;

        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public SimpleIdentificationInformation TxId;

        /// <summary>
        /// Element <b>EstblishdBaselnId</b> (Estblishd Baseline Identification) of type DocumentIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public DocumentIdentification3 EstblishdBaselnId;

        /// <summary>
        /// Element <b>TxSts</b> (Transaction Status) of type TransactionStatus4.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public TransactionStatus4 TxSts;

        /// <summary>
        /// Element <b>UsrTxRef</b> (User Transaction Reference) of type array of DocumentIdentification5.
        /// </summary>
        [XmlElementAttribute( "UsrTxRef", Order = 4 )]
        public DocumentIdentification5[] UsrTxRef;

        /// <summary>
        /// Element <b>Initr</b> (Initiator) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public BICIdentification1 Initr;

        /// <summary>
        /// Element <b>Ntfctn</b> (Notification) of type Notification1.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public Notification1 Ntfctn;

        /// <summary>
        /// Element <b>ReqForActn</b> (Request For Action) of type PendingActivity2.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public PendingActivity2 ReqForActn;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
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
    /// Class <b>PendingActivity2</b> (Pending Activity 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
    public class PendingActivity2
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type Action2Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public Action2Code Tp;

        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Desc;
    }

    /// <summary>
    /// Enumeration <b>Action2Code</b> (Action 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
    public enum Action2Code
    {

        /// <summary>
        /// <b>SBTW - Submit Twin</b>.
        /// </summary>
        SBTW,

        /// <summary>
        /// <b>RSTW - Re Submit Twin</b>.
        /// </summary>
        RSTW,

        /// <summary>
        /// <b>RSBS - Re Submit Baseline</b>.
        /// </summary>
        RSBS,

        /// <summary>
        /// <b>ARDM - Accept Or Reject Data Set Mis Matches</b>.
        /// </summary>
        ARDM,

        /// <summary>
        /// <b>ARCS - Accept Or Reject Change Of Status</b>.
        /// </summary>
        ARCS,

        /// <summary>
        /// <b>ARES - Accept Or Reject Extension Of Status</b>.
        /// </summary>
        ARES,

        /// <summary>
        /// <b>WAIT - Wait For Baseline Established</b>.
        /// </summary>
        WAIT,

        /// <summary>
        /// <b>UPDT - Update And Resend</b>.
        /// </summary>
        UPDT,

        /// <summary>
        /// <b>SBDS - Submit Data Set</b>.
        /// </summary>
        SBDS,

        /// <summary>
        /// <b>ARBA - Accept Or Reject Baseline Amendment</b>.
        /// </summary>
        ARBA,

        /// <summary>
        /// <b>ARRO - Accept Or Reject Baseline And Role</b>.
        /// </summary>
        ARRO,

        /// <summary>
        /// <b>CINR - Check Invoice Reference</b>.
        /// </summary>
        CINR,
    }

    /// <summary>
    /// Class <b>Notification1</b> (Notification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
    public class Notification1
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type NotificationType1Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public NotificationType1Code Tp;

        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string AddtlInf;
    }

    /// <summary>
    /// Enumeration <b>NotificationType1Code</b> (Notification Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
    public enum NotificationType1Code
    {

        /// <summary>
        /// <b>MWFT - Must Withdraw From Transaction</b>.
        /// </summary>
        MWFT,

        /// <summary>
        /// <b>CSDS - Cannot Submit Data Set</b>.
        /// </summary>
        CSDS,
    }

    /// <summary>
    /// Class <b>BICIdentification1</b> (BICIdentification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
    public class BICIdentification1
    {

        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BIC;
    }

    /// <summary>
    /// Class <b>DocumentIdentification5</b> (Document Identification 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
    public class DocumentIdentification5
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>IdIssr</b> (Identification Issuer) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public BICIdentification1 IdIssr;
    }

    /// <summary>
    /// Class <b>TransactionStatus4</b> (Transaction Status 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
    public class TransactionStatus4
    {

        /// <summary>
        /// Element <b>Sts</b> (Status) of type BaselineStatus3Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public BaselineStatus3Code Sts;
    }

    /// <summary>
    /// Enumeration <b>BaselineStatus3Code</b> (Baseline Status 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
    public enum BaselineStatus3Code
    {

        /// <summary>
        /// <b>PROP - Proposed</b>.
        /// </summary>
        PROP,

        /// <summary>
        /// <b>CLSD - Closed</b>.
        /// </summary>
        CLSD,

        /// <summary>
        /// <b>PMTC - Partially Matched</b>.
        /// </summary>
        PMTC,

        /// <summary>
        /// <b>ESTD - Established</b>.
        /// </summary>
        ESTD,

        /// <summary>
        /// <b>ACTV - Active</b>.
        /// </summary>
        ACTV,

        /// <summary>
        /// <b>COMP - Complete</b>.
        /// </summary>
        COMP,

        /// <summary>
        /// <b>AMRQ - Amendment Requested</b>.
        /// </summary>
        AMRQ,

        /// <summary>
        /// <b>RARQ - Re Activate Requested</b>.
        /// </summary>
        RARQ,

        /// <summary>
        /// <b>CLRQ - Close Requested</b>.
        /// </summary>
        CLRQ,

        /// <summary>
        /// <b>SCRQ - Complete Requested</b>.
        /// </summary>
        SCRQ,

        /// <summary>
        /// <b>SERQ - Status Extension Requested</b>.
        /// </summary>
        SERQ,

        /// <summary>
        /// <b>DARQ - Data Set Acceptance Requested</b>.
        /// </summary>
        DARQ,
    }

    /// <summary>
    /// Class <b>DocumentIdentification3</b> (Document Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
    public class DocumentIdentification3
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Vrsn</b> (Version) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal Vrsn;
    }

    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01" )]
    public class SimpleIdentificationInformation
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;
    }
}
