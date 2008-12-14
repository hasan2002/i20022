
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


namespace i20022.setr04800101
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id setr.048.001.01 name SubscriptionOrderConfirmationAmendmentV01 from Securities Trade business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>SbcptOrdrConfAmdmntV01</b> (Subscription Order Confirmation Amendment V01) of type SubscriptionOrderConfirmationAmendmentV01.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SubscriptionOrderConfirmationAmendmentV01 SbcptOrdrConfAmdmntV01;
    }

    /// <summary>
    /// Class <b>SubscriptionOrderConfirmationAmendmentV01</b> (Subscription Order Confirmation Amendment V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class SubscriptionOrderConfirmationAmendmentV01
    {

        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 MsgId;

        /// <summary>
        /// Element <b>PoolRef</b> (Pool Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public AdditionalReference3 PoolRef;

        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( "PrvsRef", Order = 2 )]
        public AdditionalReference3[] PrvsRef;

        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public AdditionalReference3 RltdRef;

        /// <summary>
        /// Element <b>MltplExctnDtls</b> (Multiple Execution Details) of type SubscriptionMultipleExecution3.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public SubscriptionMultipleExecution3 MltplExctnDtls;

        /// <summary>
        /// Element <b>RltdPtyDtls</b> (Related Party Details) of type array of Intermediary9.
        /// </summary>
        [XmlElementAttribute( "RltdPtyDtls", Order = 5 )]
        public Intermediary9[] RltdPtyDtls;

        /// <summary>
        /// Element <b>CpyDtls</b> (Copy Details) of type CopyInformation2.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public CopyInformation2 CpyDtls;

        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute( "Xtnsn", Order = 7 )]
        public Extension1[] Xtnsn;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
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
    /// Class <b>Extension1</b> (Extension 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class Extension1
    {

        /// <summary>
        /// Element <b>PlcAndNm</b> (Place And Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string PlcAndNm;

        /// <summary>
        /// Element <b>Txt</b> (Txt) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Txt;
    }

    /// <summary>
    /// Class <b>BICIdentification1</b> (BICIdentification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class BICIdentification1
    {

        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BIC;
    }

    /// <summary>
    /// Class <b>CopyInformation2</b> (Copy Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class CopyInformation2
    {

        /// <summary>
        /// Element <b>CpyInd</b> (Copy Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public bool CpyInd;

        /// <summary>
        /// Element <b>OrgnlRcvr</b> (Original Receiver) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public BICIdentification1 OrgnlRcvr;
    }

    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class ActiveOrHistoricCurrencyAndAmount
    {

        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Ccy;

        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [XmlTextAttribute()]
        public decimal Value;
    }

    /// <summary>
    /// Class <b>Equalisation1</b> (Equalisation 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class Equalisation1
    {

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ActiveOrHistoricCurrencyAndAmount Amt;

        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal Rate;

        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RateSpecified;
    }

    /// <summary>
    /// Class <b>Account7</b> (Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class Account7
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentification1 Id;

        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification2Choice AcctSvcr;
    }

    /// <summary>
    /// Class <b>AccountIdentification1</b> (Account Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class AccountIdentification1
    {

        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SimpleIdentificationInformation Prtry;
    }

    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class SimpleIdentificationInformation
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;
    }

    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class PartyIdentification2Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BICOrBEI of type string 
        ///  NmAndAdr of type NameAndAddress5 
        ///  PrtryId of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute( "BICOrBEI", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "NmAndAdr", typeof( NameAndAddress5 ), Order = 0 )]
        [XmlElementAttribute( "PrtryId", typeof( GenericIdentification1 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class NameAndAddress5
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PostalAddress1 Adr;
    }

    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class PostalAddress1
    {

        /// <summary>
        /// Element <b>AdrTp</b> (Address Type) of type AddressType2Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AddressType2Code AdrTp;

        /// <summary>
        /// Element <b>AdrTpSpecified</b> (Address Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdrTpSpecified;

        /// <summary>
        /// Element <b>AdrLine</b> (Address Line) of type array of string.
        /// </summary>
        [XmlElementAttribute( "AdrLine", Order = 1 )]
        public string[] AdrLine;

        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string StrtNm;

        /// <summary>
        /// Element <b>BldgNb</b> (Building Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string BldgNb;

        /// <summary>
        /// Element <b>PstCd</b> (Post Code) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string PstCd;

        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public string TwnNm;

        /// <summary>
        /// Element <b>CtrySubDvsn</b> (Country Sub Division) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string CtrySubDvsn;

        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public string Ctry;
    }

    /// <summary>
    /// Enumeration <b>AddressType2Code</b> (Address Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum AddressType2Code
    {

        /// <summary>
        /// <b>ADDR - Postal</b>.
        /// </summary>
        ADDR,

        /// <summary>
        /// <b>PBOX - POBox</b>.
        /// </summary>
        PBOX,

        /// <summary>
        /// <b>HOME - Residential</b>.
        /// </summary>
        HOME,

        /// <summary>
        /// <b>BIZZ - Business</b>.
        /// </summary>
        BIZZ,

        /// <summary>
        /// <b>MLTO - Mail To</b>.
        /// </summary>
        MLTO,

        /// <summary>
        /// <b>DLVY - Delivery To</b>.
        /// </summary>
        DLVY,
    }

    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class GenericIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string SchmeNm;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Issr;
    }

    /// <summary>
    /// Class <b>Intermediary9</b> (Intermediary 9).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class Intermediary9
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PartyIdentification2Choice Id;

        /// <summary>
        /// Element <b>Acct</b> (Account) of type Account7.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public Account7 Acct;

        /// <summary>
        /// Element <b>OrdrOrgtrElgblty</b> (Order Originator Elgblty) of type OrderOriginatorEligibility1Code.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public OrderOriginatorEligibility1Code OrdrOrgtrElgblty;

        /// <summary>
        /// Element <b>OrdrOrgtrElgbltySpecified</b> (Order Originator Elgblty Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OrdrOrgtrElgbltySpecified;

        /// <summary>
        /// Element <b>TradgPtyCpcty</b> (Trading Party Cpcty) of type TradingCapacity2Code.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public TradingCapacity2Code TradgPtyCpcty;

        /// <summary>
        /// Element <b>TradgPtyCpctySpecified</b> (Trading Party Cpcty Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TradgPtyCpctySpecified;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Role of type InvestmentFundRole2Code 
        ///  XtndedRole of type string 
        /// </summary>
        [XmlElementAttribute( "Role", typeof( InvestmentFundRole2Code ), Order = 4 )]
        [XmlElementAttribute( "XtndedRole", typeof( string ), Order = 4 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>OrderOriginatorEligibility1Code</b> (Order Originator Eligibility 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum OrderOriginatorEligibility1Code
    {

        /// <summary>
        /// <b>ELIG - Eligible</b>.
        /// </summary>
        ELIG,

        /// <summary>
        /// <b>RETL - Retail</b>.
        /// </summary>
        RETL,

        /// <summary>
        /// <b>PROF - Professional</b>.
        /// </summary>
        PROF,
    }

    /// <summary>
    /// Enumeration <b>TradingCapacity2Code</b> (Trading Capacity 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum TradingCapacity2Code
    {

        /// <summary>
        /// <b>PRIN - Principal Agent</b>.
        /// </summary>
        PRIN,

        /// <summary>
        /// <b>TAGN - Trading Agent</b>.
        /// </summary>
        TAGN,
    }

    /// <summary>
    /// Enumeration <b>InvestmentFundRole2Code</b> (Investment Fund Role 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum InvestmentFundRole2Code
    {

        /// <summary>
        /// <b>FMCO - Fund Management Company</b>.
        /// </summary>
        FMCO,

        /// <summary>
        /// <b>REGI - Registrar</b>.
        /// </summary>
        REGI,

        /// <summary>
        /// <b>TRAG - Transfer Agent</b>.
        /// </summary>
        TRAG,

        /// <summary>
        /// <b>INTR - Intermediary</b>.
        /// </summary>
        INTR,

        /// <summary>
        /// <b>DIST - Distribution</b>.
        /// </summary>
        DIST,

        /// <summary>
        /// <b>CONC - Concentrator</b>.
        /// </summary>
        CONC,

        /// <summary>
        /// <b>UCL1 - Underlying Client 1</b>.
        /// </summary>
        UCL1,

        /// <summary>
        /// <b>UCL2 - Underlying Client 2</b>.
        /// </summary>
        UCL2,

        /// <summary>
        /// <b>TRAN - Transfer Fee</b>.
        /// </summary>
        TRAN,
    }

    /// <summary>
    /// Class <b>InvestmentFundsOrderBreakdown1</b> (Investment Funds Order Breakdown 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class InvestmentFundsOrderBreakdown1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  OrdrBrkdwnTp of type FundOrderType5Code 
        ///  XtndedOrdrBrkdwnTp of type string 
        /// </summary>
        [XmlElementAttribute( "OrdrBrkdwnTp", typeof( FundOrderType5Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedOrdrBrkdwnTp", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ActiveCurrencyAndAmount Amt;
    }

    /// <summary>
    /// Enumeration <b>FundOrderType5Code</b> (Fund Order Type 5Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum FundOrderType5Code
    {

        /// <summary>
        /// <b>NSPN - Normal Staff Portion</b>.
        /// </summary>
        NSPN,

        /// <summary>
        /// <b>NCPN - Normal Client Portion</b>.
        /// </summary>
        NCPN,

        /// <summary>
        /// <b>SWSP - Staff With Savings Plan</b>.
        /// </summary>
        SWSP,

        /// <summary>
        /// <b>CWSP - Client With Savings Plan</b>.
        /// </summary>
        CWSP,
    }

    /// <summary>
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class ActiveCurrencyAndAmount
    {

        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Ccy;

        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [XmlTextAttribute()]
        public decimal Value;
    }

    /// <summary>
    /// Class <b>InvestmentAccount20</b> (Investment Account 20).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class InvestmentAccount20
    {

        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentification1 AcctId;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Tp of type FundCashAccount2Code 
        ///  XtndedTp of type string 
        /// </summary>
        [XmlElementAttribute( "Tp", typeof( FundCashAccount2Code ), Order = 1 )]
        [XmlElementAttribute( "XtndedTp", typeof( string ), Order = 1 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>FundCashAccount2Code</b> (Fund Cash Account 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum FundCashAccount2Code
    {

        /// <summary>
        /// <b>CASH - Cash Payment</b>.
        /// </summary>
        CASH,

        /// <summary>
        /// <b>CPFO - Pension Fund Ordinary</b>.
        /// </summary>
        CPFO,

        /// <summary>
        /// <b>CPFS - Pension Fund Special</b>.
        /// </summary>
        CPFS,

        /// <summary>
        /// <b>SRSA - Retirement Scheme</b>.
        /// </summary>
        SRSA,
    }

    /// <summary>
    /// Class <b>Cheque3</b> (Cheque 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class Cheque3
    {

        /// <summary>
        /// Element <b>Nb</b> (Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nb;

        /// <summary>
        /// Element <b>PyeeId</b> (Payee Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification2Choice PyeeId;

        /// <summary>
        /// Element <b>DrweeId</b> (Drawee Identification) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public FinancialInstitutionIdentification3Choice DrweeId;

        /// <summary>
        /// Element <b>DrwrId</b> (Drawer Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public PartyIdentification2Choice DrwrId;
    }

    /// <summary>
    /// Class <b>FinancialInstitutionIdentification3Choice</b> (Financial Institution Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class FinancialInstitutionIdentification3Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BIC of type string 
        ///  ClrSysMmbId of type ClearingSystemMemberIdentificationChoice 
        ///  NmAndAdr of type NameAndAddress5 
        ///  PrtryId of type SimpleIdentificationInformation 
        /// </summary>
        [XmlElementAttribute( "BIC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ClrSysMmbId", typeof( ClearingSystemMemberIdentificationChoice ), Order = 0 )]
        [XmlElementAttribute( "NmAndAdr", typeof( NameAndAddress5 ), Order = 0 )]
        [XmlElementAttribute( "PrtryId", typeof( SimpleIdentificationInformation ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>ClearingSystemMemberIdentificationChoice</b> (Clearing System Member Identification Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class ClearingSystemMemberIdentificationChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "ATBLZ", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "AUBSBs", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "AUBSBx", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CACPA", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CHBC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CHSIC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "DEBLZ", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ESNCC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "GBSC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "HKNCC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "IENSC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ITNCC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "NZNCC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "PTNCC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "RUCB", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "USCH", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "USCHU", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "USFW", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ZANCC", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public string Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType6.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType6 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType6</b> (Item Choice Type 6).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType6
    {

        /// <summary>
        /// <b>ATBLZ - ?undefined</b>.
        /// </summary>
        ATBLZ,

        /// <summary>
        /// <b>AUBSBs - ?undefined</b>.
        /// </summary>
        AUBSBs,

        /// <summary>
        /// <b>AUBSBx - ?undefined</b>.
        /// </summary>
        AUBSBx,

        /// <summary>
        /// <b>CACPA - ?undefined</b>.
        /// </summary>
        CACPA,

        /// <summary>
        /// <b>CHBC - ?undefined</b>.
        /// </summary>
        CHBC,

        /// <summary>
        /// <b>CHSIC - ?undefined</b>.
        /// </summary>
        CHSIC,

        /// <summary>
        /// <b>DEBLZ - ?undefined</b>.
        /// </summary>
        DEBLZ,

        /// <summary>
        /// <b>ESNCC - ?undefined</b>.
        /// </summary>
        ESNCC,

        /// <summary>
        /// <b>GBSC - ?undefined</b>.
        /// </summary>
        GBSC,

        /// <summary>
        /// <b>HKNCC - ?undefined</b>.
        /// </summary>
        HKNCC,

        /// <summary>
        /// <b>IENSC - ?undefined</b>.
        /// </summary>
        IENSC,

        /// <summary>
        /// <b>ITNCC - ?undefined</b>.
        /// </summary>
        ITNCC,

        /// <summary>
        /// <b>NZNCC - ?undefined</b>.
        /// </summary>
        NZNCC,

        /// <summary>
        /// <b>PTNCC - ?undefined</b>.
        /// </summary>
        PTNCC,

        /// <summary>
        /// <b>RUCB - ?undefined</b>.
        /// </summary>
        RUCB,

        /// <summary>
        /// <b>USCH - ?undefined</b>.
        /// </summary>
        USCH,

        /// <summary>
        /// <b>USCHU - ?undefined</b>.
        /// </summary>
        USCHU,

        /// <summary>
        /// <b>USFW - ?undefined</b>.
        /// </summary>
        USFW,

        /// <summary>
        /// <b>ZANCC - ?undefined</b>.
        /// </summary>
        ZANCC,
    }

    /// <summary>
    /// Class <b>BranchData</b> (Branch Data).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class BranchData
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nm;

        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PostalAddress1 PstlAdr;
    }

    /// <summary>
    /// Class <b>DirectDebitMandate4</b> (Direct Debit Mandate 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class DirectDebitMandate4
    {

        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentificationAndName3 DbtrAcct;

        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification2Choice Dbtr;

        /// <summary>
        /// Element <b>DbtrTaxIdNb</b> (Debtor Tax Identification Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string DbtrTaxIdNb;

        /// <summary>
        /// Element <b>DbtrNtlRegnNb</b> (Debtor National Registration Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string DbtrNtlRegnNb;

        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification2Choice Cdtr;

        /// <summary>
        /// Element <b>DbtrAgt</b> (Debtor Agent) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public FinancialInstitutionIdentification3Choice DbtrAgt;

        /// <summary>
        /// Element <b>DbtrAgtBrnch</b> (Debtor Agent Branch) of type BranchData.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public BranchData DbtrAgtBrnch;

        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public FinancialInstitutionIdentification3Choice CdtrAgt;

        /// <summary>
        /// Element <b>CdtrAgtBrnch</b> (Creditor Agent Branch) of type BranchData.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public BranchData CdtrAgtBrnch;

        /// <summary>
        /// Element <b>RegnId</b> (Registration Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public string RegnId;

        /// <summary>
        /// Element <b>MndtId</b> (Mandate Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public string MndtId;
    }

    /// <summary>
    /// Class <b>AccountIdentificationAndName3</b> (Account Identification And Name 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class AccountIdentificationAndName3
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type CashAccountIdentification1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CashAccountIdentification1Choice Id;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nm;
    }

    /// <summary>
    /// Class <b>CashAccountIdentification1Choice</b> (Cash Account Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class CashAccountIdentification1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BBAN of type string 
        ///  DmstAcct of type SimpleIdentificationInformation 
        ///  IBAN of type string 
        ///  UPIC of type string 
        /// </summary>
        [XmlElementAttribute( "BBAN", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "DmstAcct", typeof( SimpleIdentificationInformation ), Order = 0 )]
        [XmlElementAttribute( "IBAN", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "UPIC", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType5.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType5 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType5</b> (Item Choice Type 5).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType5
    {

        /// <summary>
        /// <b>BBAN - ?undefined</b>.
        /// </summary>
        BBAN,

        /// <summary>
        /// <b>DmstAcct - ?undefined</b>.
        /// </summary>
        DmstAcct,

        /// <summary>
        /// <b>IBAN - ?undefined</b>.
        /// </summary>
        IBAN,

        /// <summary>
        /// <b>UPIC - ?undefined</b>.
        /// </summary>
        UPIC,
    }

    /// <summary>
    /// Class <b>CreditTransfer6</b> (Credit Transfer 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class CreditTransfer6
    {

        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Ref;

        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification2Choice Dbtr;

        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public AccountIdentificationAndName3 DbtrAcct;

        /// <summary>
        /// Element <b>DbtrAgt</b> (Debtor Agent) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public FinancialInstitutionIdentification3Choice DbtrAgt;

        /// <summary>
        /// Element <b>DbtrAgtAcct</b> (Debtor Agent Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public AccountIdentificationAndName3 DbtrAgtAcct;

        /// <summary>
        /// Element <b>IntrmyAgt1</b> (Intermediary Agent 1) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public FinancialInstitutionIdentification3Choice IntrmyAgt1;

        /// <summary>
        /// Element <b>IntrmyAgt1Acct</b> (Intermediary Agent 1Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public AccountIdentificationAndName3 IntrmyAgt1Acct;

        /// <summary>
        /// Element <b>IntrmyAgt2</b> (Intermediary Agent 2) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public FinancialInstitutionIdentification3Choice IntrmyAgt2;

        /// <summary>
        /// Element <b>IntrmyAgt2Acct</b> (Intermediary Agent 2Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public AccountIdentificationAndName3 IntrmyAgt2Acct;

        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public FinancialInstitutionIdentification3Choice CdtrAgt;

        /// <summary>
        /// Element <b>CdtrAgtAcct</b> (Creditor Agent Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public AccountIdentificationAndName3 CdtrAgtAcct;

        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public PartyIdentification2Choice Cdtr;

        /// <summary>
        /// Element <b>CdtrAcct</b> (Creditor Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute( Order = 12 )]
        public AccountIdentificationAndName3 CdtrAcct;
    }

    /// <summary>
    /// Class <b>PaymentCard2</b> (Payment Card 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class PaymentCard2
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type CardType1Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CardType1Code Tp;

        /// <summary>
        /// Element <b>Nb</b> (Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nb;

        /// <summary>
        /// Element <b>HldrNm</b> (Holder Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string HldrNm;

        /// <summary>
        /// Element <b>StartDt</b> (Start Date) of type string.
        /// </summary>
        [XmlElementAttribute( DataType = "gYearMonth", Order = 3 )]
        public string StartDt;

        /// <summary>
        /// Element <b>XpryDt</b> (Expiry Date) of type string.
        /// </summary>
        [XmlElementAttribute( DataType = "gYearMonth", Order = 4 )]
        public string XpryDt;

        /// <summary>
        /// Element <b>CardIssrNm</b> (Card Issuer Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public string CardIssrNm;

        /// <summary>
        /// Element <b>CardIssrId</b> (Card Issuer Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public PartyIdentification2Choice CardIssrId;

        /// <summary>
        /// Element <b>SctyCd</b> (Security Code) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public string SctyCd;

        /// <summary>
        /// Element <b>SeqNb</b> (Sequence Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public string SeqNb;
    }

    /// <summary>
    /// Enumeration <b>CardType1Code</b> (Card Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum CardType1Code
    {

        /// <summary>
        /// <b>CRDT - Credit Card</b>.
        /// </summary>
        CRDT,

        /// <summary>
        /// <b>DBIT - Debit Card</b>.
        /// </summary>
        DBIT,
    }

    /// <summary>
    /// Class <b>PaymentInstrument12Choice</b> (Payment Instrument 12 Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class PaymentInstrument12Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BkrsDrftDtls of type Cheque3 
        ///  CdtTrfDtls of type CreditTransfer6 
        ///  ChqDtls of type Cheque3 
        ///  CshAcctDtls of type InvestmentAccount20 
        ///  DrctDbtDtls of type DirectDebitMandate4 
        ///  PmtCardDtls of type PaymentCard2 
        /// </summary>
        [XmlElementAttribute( "BkrsDrftDtls", typeof( Cheque3 ), Order = 0 )]
        [XmlElementAttribute( "CdtTrfDtls", typeof( CreditTransfer6 ), Order = 0 )]
        [XmlElementAttribute( "ChqDtls", typeof( Cheque3 ), Order = 0 )]
        [XmlElementAttribute( "CshAcctDtls", typeof( InvestmentAccount20 ), Order = 0 )]
        [XmlElementAttribute( "DrctDbtDtls", typeof( DirectDebitMandate4 ), Order = 0 )]
        [XmlElementAttribute( "PmtCardDtls", typeof( PaymentCard2 ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType7.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType7 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType7</b> (Item Choice Type 7).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType7
    {

        /// <summary>
        /// <b>BkrsDrftDtls - ?undefined</b>.
        /// </summary>
        BkrsDrftDtls,

        /// <summary>
        /// <b>CdtTrfDtls - ?undefined</b>.
        /// </summary>
        CdtTrfDtls,

        /// <summary>
        /// <b>ChqDtls - ?undefined</b>.
        /// </summary>
        ChqDtls,

        /// <summary>
        /// <b>CshAcctDtls - ?undefined</b>.
        /// </summary>
        CshAcctDtls,

        /// <summary>
        /// <b>DrctDbtDtls - ?undefined</b>.
        /// </summary>
        DrctDbtDtls,

        /// <summary>
        /// <b>PmtCardDtls - ?undefined</b>.
        /// </summary>
        PmtCardDtls,
    }

    /// <summary>
    /// Class <b>PaymentTransaction24</b> (Payment Transaction 24).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class PaymentTransaction24
    {

        /// <summary>
        /// Element <b>PmtInstrm</b> (Payment Instrument) of type PaymentInstrument12Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PaymentInstrument12Choice PmtInstrm;
    }

    /// <summary>
    /// Class <b>NameAndAddress4</b> (Name And Address 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class NameAndAddress4
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PostalAddress1 Adr;
    }

    /// <summary>
    /// Class <b>DeliveryParameters3</b> (Delivery Parameters 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class DeliveryParameters3
    {

        /// <summary>
        /// Element <b>Adr</b> (Address) of type NameAndAddress4.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public NameAndAddress4 Adr;

        /// <summary>
        /// Element <b>IssdCertNb</b> (Issued Certificate Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string IssdCertNb;
    }

    /// <summary>
    /// Class <b>DeliveringPartiesAndAccount3</b> (Delivering Parties And Account 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class DeliveringPartiesAndAccount3
    {

        /// <summary>
        /// Element <b>DlvrrsCtdnDtls</b> (Deliverers Custodian Details) of type PartyIdentificationAndAccount3.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PartyIdentificationAndAccount3 DlvrrsCtdnDtls;

        /// <summary>
        /// Element <b>DlvrrsIntrmyDtls</b> (Deliverers Intermediary Details) of type PartyIdentificationAndAccount3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentificationAndAccount3 DlvrrsIntrmyDtls;

        /// <summary>
        /// Element <b>DlvrgAgtDtls</b> (Delivering Agent Details) of type PartyIdentificationAndAccount3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PartyIdentificationAndAccount3 DlvrgAgtDtls;
    }

    /// <summary>
    /// Class <b>PartyIdentificationAndAccount3</b> (Party Identification And Account 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class PartyIdentificationAndAccount3
    {

        /// <summary>
        /// Element <b>PtyId</b> (Party Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PartyIdentification2Choice PtyId;

        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public AccountIdentification1 AcctId;
    }

    /// <summary>
    /// Class <b>ReceivingPartiesAndAccount3</b> (Receiving Parties And Account 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class ReceivingPartiesAndAccount3
    {

        /// <summary>
        /// Element <b>RcvrsCtdnDtls</b> (Receivers Custodian Details) of type PartyIdentificationAndAccount3.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PartyIdentificationAndAccount3 RcvrsCtdnDtls;

        /// <summary>
        /// Element <b>RcvrsIntrmyDtls</b> (Receivers Intermediary Details) of type PartyIdentificationAndAccount3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentificationAndAccount3 RcvrsIntrmyDtls;

        /// <summary>
        /// Element <b>RcvgAgtDtls</b> (Receiving Agent Details) of type PartyIdentificationAndAccount3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PartyIdentificationAndAccount3 RcvgAgtDtls;
    }

    /// <summary>
    /// Class <b>FundSettlementParameters3</b> (Fund Settlement Parameters 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class FundSettlementParameters3
    {

        /// <summary>
        /// Element <b>SttlmDt</b> (Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 0 )]
        public System.DateTime SttlmDt;

        /// <summary>
        /// Element <b>SttlmDtSpecified</b> (Settlement Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SttlmDtSpecified;

        /// <summary>
        /// Element <b>SttlmPlc</b> (Settlement Place) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification2Choice SttlmPlc;

        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PartyIdentification2Choice SfkpgPlc;

        /// <summary>
        /// Element <b>SctiesSttlmSysId</b> (Securities Settlement System Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string SctiesSttlmSysId;

        /// <summary>
        /// Element <b>RcvgSdDtls</b> (Receiving Side Details) of type ReceivingPartiesAndAccount3.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public ReceivingPartiesAndAccount3 RcvgSdDtls;

        /// <summary>
        /// Element <b>DlvrgSdDtls</b> (Delivering Side Details) of type DeliveringPartiesAndAccount3.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public DeliveringPartiesAndAccount3 DlvrgSdDtls;
    }

    /// <summary>
    /// Class <b>TaxCalculationInformation6</b> (Tax Calculation Information 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class TaxCalculationInformation6
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Bsis of type TaxationBasis2Code 
        ///  XtndedBsis of type string 
        /// </summary>
        [XmlElementAttribute( "Bsis", typeof( TaxationBasis2Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedBsis", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>TaxblAmt</b> (Taxable Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ActiveCurrencyAnd13DecimalAmount TaxblAmt;
    }

    /// <summary>
    /// Enumeration <b>TaxationBasis2Code</b> (Taxation Basis 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum TaxationBasis2Code
    {

        /// <summary>
        /// <b>FLAT - Flat</b>.
        /// </summary>
        FLAT,

        /// <summary>
        /// <b>PERU - Per Unit</b>.
        /// </summary>
        PERU,
    }

    /// <summary>
    /// Class <b>ActiveCurrencyAnd13DecimalAmount</b> (Active Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class ActiveCurrencyAnd13DecimalAmount
    {

        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Ccy;

        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [XmlTextAttribute()]
        public decimal Value;
    }

    /// <summary>
    /// Class <b>Tax14</b> (Tax 14).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class Tax14
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Tp of type TaxType11Code 
        ///  XtndedTp of type string 
        /// </summary>
        [XmlElementAttribute( "Tp", typeof( TaxType11Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedTp", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ActiveCurrencyAnd13DecimalAmount Amt;

        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public decimal Rate;

        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RateSpecified;

        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string Ctry;

        /// <summary>
        /// Element <b>RcptId</b> (Recipient Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification2Choice RcptId;

        /// <summary>
        /// Element <b>XmptnInd</b> (Exemption Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public bool XmptnInd;

        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// This element can be:
        ///  XmptnRsn of type TaxExemptReason1Code 
        ///  XtndedXmptnRsn of type string 
        /// </summary>
        [XmlElementAttribute( "XmptnRsn", typeof( TaxExemptReason1Code ), Order = 6 )]
        [XmlElementAttribute( "XtndedXmptnRsn", typeof( string ), Order = 6 )]
        public object Item1;

        /// <summary>
        /// Element <b>TaxClctnDtls</b> (Tax Calculation Details) of type TaxCalculationInformation6.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public TaxCalculationInformation6 TaxClctnDtls;
    }

    /// <summary>
    /// Enumeration <b>TaxType11Code</b> (Tax Type 11 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum TaxType11Code
    {

        /// <summary>
        /// <b>PROV - Provincial</b>.
        /// </summary>
        PROV,

        /// <summary>
        /// <b>NATI - National Tax</b>.
        /// </summary>
        NATI,

        /// <summary>
        /// <b>STAT - State Tax</b>.
        /// </summary>
        STAT,

        /// <summary>
        /// <b>WITH - Withdrawal</b>.
        /// </summary>
        WITH,

        /// <summary>
        /// <b>KAPA - Capital Gain Tax</b>.
        /// </summary>
        KAPA,

        /// <summary>
        /// <b>INPO - Interim Profit Tax</b>.
        /// </summary>
        INPO,

        /// <summary>
        /// <b>STAM - Stamp Duty</b>.
        /// </summary>
        STAM,

        /// <summary>
        /// <b>WTAX - Wealth Tax</b>.
        /// </summary>
        WTAX,

        /// <summary>
        /// <b>INHT - Inheritance Tax</b>.
        /// </summary>
        INHT,

        /// <summary>
        /// <b>SOSU - Solidarity Surcharge</b>.
        /// </summary>
        SOSU,

        /// <summary>
        /// <b>CTAX - Tax Credit</b>.
        /// </summary>
        CTAX,

        /// <summary>
        /// <b>GIFT - Gift Tax</b>.
        /// </summary>
        GIFT,

        /// <summary>
        /// <b>COAX - Consumption Tax</b>.
        /// </summary>
        COAX,

        /// <summary>
        /// <b>EUTR - EUTax Retention</b>.
        /// </summary>
        EUTR,

        /// <summary>
        /// <b>AKT1 - Aktiengewinn 1</b>.
        /// </summary>
        AKT1,

        /// <summary>
        /// <b>AKT2 - Aktiengewinn 2</b>.
        /// </summary>
        AKT2,

        /// <summary>
        /// <b>ZWIS - Zwischengewinn</b>.
        /// </summary>
        ZWIS,
    }

    /// <summary>
    /// Enumeration <b>TaxExemptReason1Code</b> (Tax Exempt Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum TaxExemptReason1Code
    {

        /// <summary>
        /// <b>NONE - None</b>.
        /// </summary>
        NONE,

        /// <summary>
        /// <b>MASA - Maxi ISA</b>.
        /// </summary>
        MASA,

        /// <summary>
        /// <b>MISA - Mini Cash ISA</b>.
        /// </summary>
        MISA,

        /// <summary>
        /// <b>SISA - Mini Stocks And Shares ISA</b>.
        /// </summary>
        SISA,

        /// <summary>
        /// <b>IISA - Mini Insurance ISA</b>.
        /// </summary>
        IISA,

        /// <summary>
        /// <b>CUYP - Current Year Payment</b>.
        /// </summary>
        CUYP,

        /// <summary>
        /// <b>PRYP - Prior Year Payment</b>.
        /// </summary>
        PRYP,

        /// <summary>
        /// <b>ASTR - Asset Transfer</b>.
        /// </summary>
        ASTR,

        /// <summary>
        /// <b>EMPY - Employee Prior Year</b>.
        /// </summary>
        EMPY,

        /// <summary>
        /// <b>EMCY - Employee Current Year</b>.
        /// </summary>
        EMCY,

        /// <summary>
        /// <b>EPRY - Employer Prior Year</b>.
        /// </summary>
        EPRY,

        /// <summary>
        /// <b>ECYE - Employer Current Year</b>.
        /// </summary>
        ECYE,

        /// <summary>
        /// <b>NFPI - Non Fund Prototype IRA</b>.
        /// </summary>
        NFPI,

        /// <summary>
        /// <b>NFQP - Non Fund Qualified Plan</b>.
        /// </summary>
        NFQP,

        /// <summary>
        /// <b>DECP - Defined Contribution Plan</b>.
        /// </summary>
        DECP,

        /// <summary>
        /// <b>IRAC - Individual Retirement Account</b>.
        /// </summary>
        IRAC,

        /// <summary>
        /// <b>IRAR - Individual Retirement Account Rollover</b>.
        /// </summary>
        IRAR,

        /// <summary>
        /// <b>KEOG - KEOGH</b>.
        /// </summary>
        KEOG,

        /// <summary>
        /// <b>PFSP - Profit Sharing Plan</b>.
        /// </summary>
        PFSP,

        /// <summary>
        /// <b>Item401K - ?undefined</b>.
        /// </summary>
        [XmlEnumAttribute( "401K" )]
        Item401K,

        /// <summary>
        /// <b>SIRA - Self Directed IRA</b>.
        /// </summary>
        SIRA,

        /// <summary>
        /// <b>Item403B - ?undefined</b>.
        /// </summary>
        [XmlEnumAttribute( "403B" )]
        Item403B,

        /// <summary>
        /// <b>Item457X - ?undefined</b>.
        /// </summary>
        [XmlEnumAttribute( "457X" )]
        Item457X,

        /// <summary>
        /// <b>RIRA - Roth IRAFund Prototype</b>.
        /// </summary>
        RIRA,

        /// <summary>
        /// <b>RIAN - Roth IRANon Prototype</b>.
        /// </summary>
        RIAN,

        /// <summary>
        /// <b>RCRF - Roth Conversion IRAFund Prototype</b>.
        /// </summary>
        RCRF,

        /// <summary>
        /// <b>RCIP - Roth Conversion IRANon Prototype</b>.
        /// </summary>
        RCIP,

        /// <summary>
        /// <b>EIFP - Education IRAFund Prototype</b>.
        /// </summary>
        EIFP,

        /// <summary>
        /// <b>EIOP - Education IRANon Prototype</b>.
        /// </summary>
        EIOP,
    }

    /// <summary>
    /// Class <b>TotalTaxes3</b> (Total Taxes 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class TotalTaxes3
    {

        /// <summary>
        /// Element <b>TtlAmtOfTaxs</b> (Total Amount Of Taxes) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ActiveCurrencyAnd13DecimalAmount TtlAmtOfTaxs;

        /// <summary>
        /// Element <b>TaxblIncmPerDvdd</b> (Taxable Income Per Dividend) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ActiveCurrencyAndAmount TaxblIncmPerDvdd;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  EUCptlGn of type EUCapitalGain2Code 
        ///  XtndedEUCptlGn of type string 
        /// </summary>
        [XmlElementAttribute( "EUCptlGn", typeof( EUCapitalGain2Code ), Order = 2 )]
        [XmlElementAttribute( "XtndedEUCptlGn", typeof( string ), Order = 2 )]
        public object Item;

        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// This element can be:
        ///  EUDvddSts of type EUDividendStatus1Code 
        ///  XtndedEUDvddSts of type string 
        /// </summary>
        [XmlElementAttribute( "EUDvddSts", typeof( EUDividendStatus1Code ), Order = 3 )]
        [XmlElementAttribute( "XtndedEUDvddSts", typeof( string ), Order = 3 )]
        public object Item1;

        /// <summary>
        /// Element <b>PctgOfDebtClm</b> (Percentage Of Debt Claim) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public decimal PctgOfDebtClm;

        /// <summary>
        /// Element <b>PctgOfDebtClmSpecified</b> (Percentage Of Debt Claim Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PctgOfDebtClmSpecified;

        /// <summary>
        /// Element <b>TaxDtls</b> (Tax Details) of type array of Tax14.
        /// </summary>
        [XmlElementAttribute( "TaxDtls", Order = 5 )]
        public Tax14[] TaxDtls;
    }

    /// <summary>
    /// Enumeration <b>EUCapitalGain2Code</b> (EUCapital Gain 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum EUCapitalGain2Code
    {

        /// <summary>
        /// <b>EUSI - Capital Gain In Scope</b>.
        /// </summary>
        EUSI,

        /// <summary>
        /// <b>EUSO - Capital Gain Out Scope</b>.
        /// </summary>
        EUSO,

        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
    }

    /// <summary>
    /// Enumeration <b>EUDividendStatus1Code</b> (EUDividend Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum EUDividendStatus1Code
    {

        /// <summary>
        /// <b>DIVI - Dividend In Scope</b>.
        /// </summary>
        DIVI,

        /// <summary>
        /// <b>DIVO - Dividend Out Scope</b>.
        /// </summary>
        DIVO,

        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
    }

    /// <summary>
    /// Class <b>CommissionWaiver3</b> (Commission Waiver 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class CommissionWaiver3
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  InstrBsis of type WaivingInstruction1Code 
        ///  XtndedInstrBsis of type string 
        /// </summary>
        [XmlElementAttribute( "InstrBsis", typeof( WaivingInstruction1Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedInstrBsis", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>WvdRate</b> (Waived Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal WvdRate;
    }

    /// <summary>
    /// Enumeration <b>WaivingInstruction1Code</b> (Waiving Instruction 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum WaivingInstruction1Code
    {

        /// <summary>
        /// <b>WICA - Waive In Cash</b>.
        /// </summary>
        WICA,

        /// <summary>
        /// <b>WIUN - Waive In Units</b>.
        /// </summary>
        WIUN,
    }

    /// <summary>
    /// Class <b>Commission10</b> (Commission 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class Commission10
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Tp of type CommissionType6Code 
        ///  XtndedTp of type string 
        /// </summary>
        [XmlElementAttribute( "Tp", typeof( CommissionType6Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedTp", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// This element can be:
        ///  Bsis of type TaxationBasis4Code 
        ///  XtndedBsis of type string 
        /// </summary>
        [XmlElementAttribute( "Bsis", typeof( TaxationBasis4Code ), Order = 1 )]
        [XmlElementAttribute( "XtndedBsis", typeof( string ), Order = 1 )]
        public object Item1;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public ActiveCurrencyAnd13DecimalAmount Amt;

        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public decimal Rate;

        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RateSpecified;

        /// <summary>
        /// Element <b>RcptId</b> (Recipient Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification2Choice RcptId;

        /// <summary>
        /// Element <b>ComrclAgrmtRef</b> (Commercial Agreement Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public string ComrclAgrmtRef;

        /// <summary>
        /// Element <b>WvgDtls</b> (Waiving Details) of type CommissionWaiver3.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public CommissionWaiver3 WvgDtls;
    }

    /// <summary>
    /// Enumeration <b>CommissionType6Code</b> (Commission Type 6Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum CommissionType6Code
    {

        /// <summary>
        /// <b>FEND - Front End Load</b>.
        /// </summary>
        FEND,

        /// <summary>
        /// <b>BEND - Back End Load</b>.
        /// </summary>
        BEND,

        /// <summary>
        /// <b>CDPL - Commission De Placement</b>.
        /// </summary>
        CDPL,
    }

    /// <summary>
    /// Enumeration <b>TaxationBasis4Code</b> (Taxation Basis 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum TaxationBasis4Code
    {

        /// <summary>
        /// <b>FLAT - Flat</b>.
        /// </summary>
        FLAT,

        /// <summary>
        /// <b>PERU - Per Unit</b>.
        /// </summary>
        PERU,

        /// <summary>
        /// <b>GRAM - Gross Amount</b>.
        /// </summary>
        GRAM,

        /// <summary>
        /// <b>NEAM - Net Amount</b>.
        /// </summary>
        NEAM,
    }

    /// <summary>
    /// Class <b>TotalCommissions3</b> (Total Commissions 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class TotalCommissions3
    {

        /// <summary>
        /// Element <b>TtlAmtOfComssns</b> (Total Amount Of Commissions) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ActiveCurrencyAnd13DecimalAmount TtlAmtOfComssns;

        /// <summary>
        /// Element <b>ComssnDtls</b> (Commission Details) of type array of Commission10.
        /// </summary>
        [XmlElementAttribute( "ComssnDtls", Order = 1 )]
        public Commission10[] ComssnDtls;
    }

    /// <summary>
    /// Class <b>Charge18</b> (Charge 18).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class Charge18
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Tp of type ChargeType11Code 
        ///  XtndedTp of type string 
        /// </summary>
        [XmlElementAttribute( "Tp", typeof( ChargeType11Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedTp", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// This element can be:
        ///  ChrgBsis of type TaxationBasis2Code 
        ///  XtndedChrgBsis of type string 
        /// </summary>
        [XmlElementAttribute( "ChrgBsis", typeof( TaxationBasis2Code ), Order = 1 )]
        [XmlElementAttribute( "XtndedChrgBsis", typeof( string ), Order = 1 )]
        public object Item1;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public ActiveCurrencyAnd13DecimalAmount Amt;

        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public decimal Rate;

        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RateSpecified;

        /// <summary>
        /// Element <b>RcptId</b> (Recipient Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification2Choice RcptId;
    }

    /// <summary>
    /// Enumeration <b>ChargeType11Code</b> (Charge Type 11 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum ChargeType11Code
    {

        /// <summary>
        /// <b>BEND - Back End Load</b>.
        /// </summary>
        BEND,

        /// <summary>
        /// <b>FEND - Front End Load</b>.
        /// </summary>
        FEND,

        /// <summary>
        /// <b>SWIT - Switch</b>.
        /// </summary>
        SWIT,

        /// <summary>
        /// <b>DLEV - Dilution Levy</b>.
        /// </summary>
        DLEV,

        /// <summary>
        /// <b>DISC - Discount</b>.
        /// </summary>
        DISC,

        /// <summary>
        /// <b>PENA - Penalty</b>.
        /// </summary>
        PENA,

        /// <summary>
        /// <b>POST - Postage Charge</b>.
        /// </summary>
        POST,

        /// <summary>
        /// <b>REGF - Regulatory Fee</b>.
        /// </summary>
        REGF,

        /// <summary>
        /// <b>SHIP - Shipping Charge</b>.
        /// </summary>
        SHIP,

        /// <summary>
        /// <b>CHAR - Charges</b>.
        /// </summary>
        CHAR,

        /// <summary>
        /// <b>CDSC - Contingency Deferred Sales Charge</b>.
        /// </summary>
        CDSC,

        /// <summary>
        /// <b>CBCH - Correspondent Bank Charge</b>.
        /// </summary>
        CBCH,

        /// <summary>
        /// <b>PREM - Premium</b>.
        /// </summary>
        PREM,

        /// <summary>
        /// <b>INIT - Initial</b>.
        /// </summary>
        INIT,

        /// <summary>
        /// <b>BRKF - Brokerage Fee</b>.
        /// </summary>
        BRKF,

        /// <summary>
        /// <b>UCIC - UCITSCommission</b>.
        /// </summary>
        UCIC,
    }

    /// <summary>
    /// Class <b>TotalCharges3</b> (Total Charges 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class TotalCharges3
    {

        /// <summary>
        /// Element <b>TtlAmtOfChrgs</b> (Total Amount Of Charges) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ActiveCurrencyAnd13DecimalAmount TtlAmtOfChrgs;

        /// <summary>
        /// Element <b>ChrgDtls</b> (Charge Details) of type array of Charge18.
        /// </summary>
        [XmlElementAttribute( "ChrgDtls", Order = 1 )]
        public Charge18[] ChrgDtls;
    }

    /// <summary>
    /// Class <b>ForeignExchangeTerms7</b> (Foreign Exchange Terms 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class ForeignExchangeTerms7
    {

        /// <summary>
        /// Element <b>ToAmt</b> (To Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ActiveCurrencyAnd13DecimalAmount ToAmt;

        /// <summary>
        /// Element <b>FrAmt</b> (From Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ActiveCurrencyAndAmount FrAmt;

        /// <summary>
        /// Element <b>UnitCcy</b> (Unit Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string UnitCcy;

        /// <summary>
        /// Element <b>QtdCcy</b> (Quoted Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string QtdCcy;

        /// <summary>
        /// Element <b>XchgRate</b> (Exchange Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public decimal XchgRate;

        /// <summary>
        /// Element <b>QtnDt</b> (Quotation Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public System.DateTime QtnDt;

        /// <summary>
        /// Element <b>QtnDtSpecified</b> (Quotation Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool QtnDtSpecified;

        /// <summary>
        /// Element <b>QtgInstn</b> (Quoting Institution) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public PartyIdentification2Choice QtgInstn;
    }

    /// <summary>
    /// Class <b>ProfitAndLoss1Choice</b> (Profit And Loss 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class ProfitAndLoss1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( "Loss", typeof( ActiveCurrencyAnd13DecimalAmount ), Order = 0 )]
        [XmlElementAttribute( "Prft", typeof( ActiveCurrencyAnd13DecimalAmount ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public ActiveCurrencyAnd13DecimalAmount Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType4.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType4</b> (Item Choice Type 4).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType4
    {

        /// <summary>
        /// <b>Loss - ?undefined</b>.
        /// </summary>
        Loss,

        /// <summary>
        /// <b>Prft - ?undefined</b>.
        /// </summary>
        Prft,
    }

    /// <summary>
    /// Class <b>PriceValue1</b> (Price Value 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class PriceValue1
    {

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ActiveCurrencyAnd13DecimalAmount Amt;
    }

    /// <summary>
    /// Class <b>UnitPrice10</b> (Unit Price 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class UnitPrice10
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Tp of type TypeOfPrice10Code 
        ///  XtndedTp of type string 
        /// </summary>
        [XmlElementAttribute( "Tp", typeof( TypeOfPrice10Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedTp", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>Val</b> (Value) of type PriceValue1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PriceValue1 Val;

        /// <summary>
        /// Element <b>PricMtd</b> (Price Method) of type PriceMethod1Code.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PriceMethod1Code PricMtd;

        /// <summary>
        /// Element <b>PricMtdSpecified</b> (Price Method Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PricMtdSpecified;

        /// <summary>
        /// Element <b>NbOfDaysAcrd</b> (Number Of Days Accrued) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public decimal NbOfDaysAcrd;

        /// <summary>
        /// Element <b>NbOfDaysAcrdSpecified</b> (Number Of Days Accrued Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NbOfDaysAcrdSpecified;

        /// <summary>
        /// Element <b>TaxblIncmPerShr</b> (Taxable Income Per Share) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public ActiveCurrencyAnd13DecimalAmount TaxblIncmPerShr;

        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// This element can be:
        ///  TaxblIncmPerShrClctd of type TaxableIncomePerShareCalculated2Code 
        ///  XtndedTaxblIncmPerShrClctd of type string 
        /// </summary>
        [XmlElementAttribute( "TaxblIncmPerShrClctd", typeof( TaxableIncomePerShareCalculated2Code ), Order = 5 )]
        [XmlElementAttribute( "XtndedTaxblIncmPerShrClctd", typeof( string ), Order = 5 )]
        public object Item1;

        /// <summary>
        /// Element <b>PricDiffRsn</b> (Price Difference Reason) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string PricDiffRsn;
    }

    /// <summary>
    /// Enumeration <b>TypeOfPrice10Code</b> (Type Of Price 10 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum TypeOfPrice10Code
    {

        /// <summary>
        /// <b>BIDE - Bid</b>.
        /// </summary>
        BIDE,

        /// <summary>
        /// <b>OFFR - Offer</b>.
        /// </summary>
        OFFR,

        /// <summary>
        /// <b>NAVL - Net Asset Value</b>.
        /// </summary>
        NAVL,

        /// <summary>
        /// <b>CREA - Creation</b>.
        /// </summary>
        CREA,

        /// <summary>
        /// <b>CANC - Request To Cancel</b>.
        /// </summary>
        CANC,

        /// <summary>
        /// <b>INTE - Interest</b>.
        /// </summary>
        INTE,

        /// <summary>
        /// <b>SWNG - Swing</b>.
        /// </summary>
        SWNG,

        /// <summary>
        /// <b>MIDD - Mid</b>.
        /// </summary>
        MIDD,

        /// <summary>
        /// <b>RINV - Reinvestment</b>.
        /// </summary>
        RINV,

        /// <summary>
        /// <b>SWIC - Switch</b>.
        /// </summary>
        SWIC,

        /// <summary>
        /// <b>DDVR - Daily Dividend Rate</b>.
        /// </summary>
        DDVR,

        /// <summary>
        /// <b>ACTU - Actual</b>.
        /// </summary>
        ACTU,
    }

    /// <summary>
    /// Enumeration <b>PriceMethod1Code</b> (Price Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum PriceMethod1Code
    {

        /// <summary>
        /// <b>FORW - Forward Price</b>.
        /// </summary>
        FORW,

        /// <summary>
        /// <b>HIST - Historical Price</b>.
        /// </summary>
        HIST,
    }

    /// <summary>
    /// Enumeration <b>TaxableIncomePerShareCalculated2Code</b> (Taxable Income Per Share Calculated 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum TaxableIncomePerShareCalculated2Code
    {

        /// <summary>
        /// <b>TSIY - Fund Calculates</b>.
        /// </summary>
        TSIY,

        /// <summary>
        /// <b>TSIN - Fund Does Not Calculate</b>.
        /// </summary>
        TSIN,

        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
    }

    /// <summary>
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class DateAndDateTimeChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( "Dt", typeof( System.DateTime ), DataType = "date", Order = 0 )]
        [XmlElementAttribute( "DtTm", typeof( System.DateTime ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public System.DateTime Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType3
    {

        /// <summary>
        /// <b>Dt - ?undefined</b>.
        /// </summary>
        Dt,

        /// <summary>
        /// <b>DtTm - ?undefined</b>.
        /// </summary>
        DtTm,
    }

    /// <summary>
    /// Class <b>FinancialInstrumentQuantity1</b> (Financial Instrument Quantity 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class FinancialInstrumentQuantity1
    {

        /// <summary>
        /// Element <b>Unit</b> (Unit) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public decimal Unit;
    }

    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class AlternateSecurityIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "DmstIdSrc", typeof( string ), Order = 1 )]
        [XmlElementAttribute( "PrtryIdSrc", typeof( string ), Order = 1 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public string Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType1
    {

        /// <summary>
        /// <b>DmstIdSrc - ?undefined</b>.
        /// </summary>
        DmstIdSrc,

        /// <summary>
        /// <b>PrtryIdSrc - ?undefined</b>.
        /// </summary>
        PrtryIdSrc,
    }

    /// <summary>
    /// Class <b>SecurityIdentification3Choice</b> (Security Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class SecurityIdentification3Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Belgn of type string 
        ///  Blmbrg of type string 
        ///  CTA of type string 
        ///  CUSIP of type string 
        ///  Cmon of type string 
        ///  Dtch of type string 
        ///  ISIN of type string 
        ///  OthrPrtryId of type AlternateSecurityIdentification1 
        ///  QUICK of type string 
        ///  RIC of type string 
        ///  SCVM of type string 
        ///  SEDOL of type string 
        ///  TckrSymb of type string 
        ///  Vlrn of type string 
        ///  Wrtppr of type string 
        /// </summary>
        [XmlElementAttribute( "Belgn", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Blmbrg", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CTA", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CUSIP", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Cmon", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Dtch", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ISIN", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "OthrPrtryId", typeof( AlternateSecurityIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "QUICK", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "RIC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SCVM", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SEDOL", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "TckrSymb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Vlrn", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Wrtppr", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType2
    {

        /// <summary>
        /// <b>Belgn - ?undefined</b>.
        /// </summary>
        Belgn,

        /// <summary>
        /// <b>Blmbrg - ?undefined</b>.
        /// </summary>
        Blmbrg,

        /// <summary>
        /// <b>CTA - ?undefined</b>.
        /// </summary>
        CTA,

        /// <summary>
        /// <b>CUSIP - ?undefined</b>.
        /// </summary>
        CUSIP,

        /// <summary>
        /// <b>Cmon - ?undefined</b>.
        /// </summary>
        Cmon,

        /// <summary>
        /// <b>Dtch - ?undefined</b>.
        /// </summary>
        Dtch,

        /// <summary>
        /// <b>ISIN - ?undefined</b>.
        /// </summary>
        ISIN,

        /// <summary>
        /// <b>OthrPrtryId - ?undefined</b>.
        /// </summary>
        OthrPrtryId,

        /// <summary>
        /// <b>QUICK - ?undefined</b>.
        /// </summary>
        QUICK,

        /// <summary>
        /// <b>RIC - ?undefined</b>.
        /// </summary>
        RIC,

        /// <summary>
        /// <b>SCVM - ?undefined</b>.
        /// </summary>
        SCVM,

        /// <summary>
        /// <b>SEDOL - ?undefined</b>.
        /// </summary>
        SEDOL,

        /// <summary>
        /// <b>TckrSymb - ?undefined</b>.
        /// </summary>
        TckrSymb,

        /// <summary>
        /// <b>Vlrn - ?undefined</b>.
        /// </summary>
        Vlrn,

        /// <summary>
        /// <b>Wrtppr - ?undefined</b>.
        /// </summary>
        Wrtppr,
    }

    /// <summary>
    /// Class <b>FinancialInstrument10</b> (Financial Instrument 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class FinancialInstrument10
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SecurityIdentification3Choice Id;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nm;

        /// <summary>
        /// Element <b>SplmtryId</b> (Supplementary Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string SplmtryId;

        /// <summary>
        /// Element <b>ClssTp</b> (Class Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string ClssTp;

        /// <summary>
        /// Element <b>SctiesForm</b> (Securities Form) of type FormOfSecurity1Code.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public FormOfSecurity1Code SctiesForm;

        /// <summary>
        /// Element <b>SctiesFormSpecified</b> (Securities Form Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SctiesFormSpecified;

        /// <summary>
        /// Element <b>DstrbtnPlcy</b> (Distribution Policy) of type DistributionPolicy1Code.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public DistributionPolicy1Code DstrbtnPlcy;

        /// <summary>
        /// Element <b>DstrbtnPlcySpecified</b> (Distribution Policy Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DstrbtnPlcySpecified;

        /// <summary>
        /// Element <b>PdctGrp</b> (Product Group) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string PdctGrp;
    }

    /// <summary>
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum FormOfSecurity1Code
    {

        /// <summary>
        /// <b>BEAR - Bearer</b>.
        /// </summary>
        BEAR,

        /// <summary>
        /// <b>REGD - Registered</b>.
        /// </summary>
        REGD,
    }

    /// <summary>
    /// Enumeration <b>DistributionPolicy1Code</b> (Distribution Policy 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum DistributionPolicy1Code
    {

        /// <summary>
        /// <b>DIST - Distribution</b>.
        /// </summary>
        DIST,

        /// <summary>
        /// <b>ACCU - Accumulation</b>.
        /// </summary>
        ACCU,
    }

    /// <summary>
    /// Class <b>FundOrderType3</b> (Fund Order Type 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class FundOrderType3
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  OrdrTp of type FundOrderType4Code 
        ///  XtndedOrdrTp of type string 
        /// </summary>
        [XmlElementAttribute( "OrdrTp", typeof( FundOrderType4Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedOrdrTp", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>FundOrderType4Code</b> (Fund Order Type 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum FundOrderType4Code
    {

        /// <summary>
        /// <b>BEDB - Bed And Breakfast</b>.
        /// </summary>
        BEDB,

        /// <summary>
        /// <b>INVP - Investment Plan</b>.
        /// </summary>
        INVP,

        /// <summary>
        /// <b>PREA - Pre Advice</b>.
        /// </summary>
        PREA,

        /// <summary>
        /// <b>STAF - Staff Order</b>.
        /// </summary>
        STAF,

        /// <summary>
        /// <b>RGSV - Regular Savings Plan</b>.
        /// </summary>
        RGSV,

        /// <summary>
        /// <b>RGSU - Regular Savings Plan Update</b>.
        /// </summary>
        RGSU,

        /// <summary>
        /// <b>RDIV - Reinvestment Of Dividend</b>.
        /// </summary>
        RDIV,
    }

    /// <summary>
    /// Class <b>SubscriptionExecution6</b> (Subscription Execution 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class SubscriptionExecution6
    {

        /// <summary>
        /// Element <b>OrdrRef</b> (Order Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string OrdrRef;

        /// <summary>
        /// Element <b>ClntRef</b> (Client Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string ClntRef;

        /// <summary>
        /// Element <b>DealRef</b> (Deal Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string DealRef;

        /// <summary>
        /// Element <b>OrdrTp</b> (Order Type) of type array of FundOrderType3.
        /// </summary>
        [XmlElementAttribute( "OrdrTp", Order = 3 )]
        public FundOrderType3[] OrdrTp;

        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument10.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public FinancialInstrument10 FinInstrmDtls;

        /// <summary>
        /// Element <b>SubAcctForHldg</b> (Sub Account For Holding) of type SubAccount1.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public SubAccount1 SubAcctForHldg;

        /// <summary>
        /// Element <b>UnitsNb</b> (Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public FinancialInstrumentQuantity1 UnitsNb;

        /// <summary>
        /// Element <b>NetAmt</b> (Net Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public ActiveCurrencyAndAmount NetAmt;

        /// <summary>
        /// Element <b>GrssAmt</b> (Gross Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public ActiveCurrencyAndAmount GrssAmt;

        /// <summary>
        /// Element <b>Rndg</b> (Rounding) of type RoundingDirection2Code.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public RoundingDirection2Code Rndg;

        /// <summary>
        /// Element <b>RndgSpecified</b> (Rounding Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RndgSpecified;

        /// <summary>
        /// Element <b>TradDtTm</b> (Trade Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public DateAndDateTimeChoice TradDtTm;

        /// <summary>
        /// Element <b>DealgPricDtls</b> (Dealg Price Details) of type UnitPrice10.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public UnitPrice10 DealgPricDtls;

        /// <summary>
        /// Element <b>InftvPricDtls</b> (Inftv Price Details) of type array of UnitPrice10.
        /// </summary>
        [XmlElementAttribute( "InftvPricDtls", Order = 12 )]
        public UnitPrice10[] InftvPricDtls;

        /// <summary>
        /// Element <b>SttlmAmt</b> (Settlement Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 13 )]
        public ActiveCurrencyAndAmount SttlmAmt;

        /// <summary>
        /// Element <b>CshSttlmDt</b> (Cash Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 14 )]
        public System.DateTime CshSttlmDt;

        /// <summary>
        /// Element <b>CshSttlmDtSpecified</b> (Cash Settlement Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CshSttlmDtSpecified;

        /// <summary>
        /// Element <b>SttlmMtd</b> (Settlement Method) of type DeliveryReceiptType2Code.
        /// </summary>
        [XmlElementAttribute( Order = 15 )]
        public DeliveryReceiptType2Code SttlmMtd;

        /// <summary>
        /// Element <b>SttlmMtdSpecified</b> (Settlement Method Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SttlmMtdSpecified;

        /// <summary>
        /// Element <b>PrtlyExctdInd</b> (Partially Executed Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 16 )]
        public bool PrtlyExctdInd;

        /// <summary>
        /// Element <b>BestExctn</b> (Best Execution) of type BestExecution1Code.
        /// </summary>
        [XmlElementAttribute( Order = 17 )]
        public BestExecution1Code BestExctn;

        /// <summary>
        /// Element <b>BestExctnSpecified</b> (Best Execution Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BestExctnSpecified;

        /// <summary>
        /// Element <b>CumDvddInd</b> (Cum Dividend Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 18 )]
        public bool CumDvddInd;

        /// <summary>
        /// Element <b>IntrmPrftAmt</b> (Interim Profit Amount) of type ProfitAndLoss1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 19 )]
        public ProfitAndLoss1Choice IntrmPrftAmt;

        /// <summary>
        /// Element <b>FXDtls</b> (FXDetails) of type array of ForeignExchangeTerms7.
        /// </summary>
        [XmlElementAttribute( "FXDtls", Order = 20 )]
        public ForeignExchangeTerms7[] FXDtls;

        /// <summary>
        /// Element <b>IncmPref</b> (Income Preference) of type IncomePreference1Code.
        /// </summary>
        [XmlElementAttribute( Order = 21 )]
        public IncomePreference1Code IncmPref;

        /// <summary>
        /// Element <b>IncmPrefSpecified</b> (Income Preference Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IncmPrefSpecified;

        /// <summary>
        /// Element <b>LttrInttRef</b> (Letter Intent Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 22 )]
        public string LttrInttRef;

        /// <summary>
        /// Element <b>AcmltnRghtRef</b> (Accumulation Right Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 23 )]
        public string AcmltnRghtRef;

        /// <summary>
        /// Element <b>ChrgGnlDtls</b> (Charge General Details) of type TotalCharges3.
        /// </summary>
        [XmlElementAttribute( Order = 24 )]
        public TotalCharges3 ChrgGnlDtls;

        /// <summary>
        /// Element <b>ComssnGnlDtls</b> (Commission General Details) of type TotalCommissions3.
        /// </summary>
        [XmlElementAttribute( Order = 25 )]
        public TotalCommissions3 ComssnGnlDtls;

        /// <summary>
        /// Element <b>TaxGnlDtls</b> (Tax General Details) of type TotalTaxes3.
        /// </summary>
        [XmlElementAttribute( Order = 26 )]
        public TotalTaxes3 TaxGnlDtls;

        /// <summary>
        /// Element <b>SttlmAndCtdyDtls</b> (Settlement And Custody Details) of type FundSettlementParameters3.
        /// </summary>
        [XmlElementAttribute( Order = 27 )]
        public FundSettlementParameters3 SttlmAndCtdyDtls;

        /// <summary>
        /// Element <b>PhysDlvryInd</b> (Physical Delivery Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 28 )]
        public bool PhysDlvryInd;

        /// <summary>
        /// Element <b>PhysDlvryDtls</b> (Physical Delivery Details) of type DeliveryParameters3.
        /// </summary>
        [XmlElementAttribute( Order = 29 )]
        public DeliveryParameters3 PhysDlvryDtls;

        /// <summary>
        /// Element <b>ReqdSttlmCcy</b> (Requested Settlement Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 30 )]
        public string ReqdSttlmCcy;

        /// <summary>
        /// Element <b>ReqdNAVCcy</b> (Requested NAVCurrency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 31 )]
        public string ReqdNAVCcy;

        /// <summary>
        /// Element <b>Rfnd</b> (Refund) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 32 )]
        public ActiveCurrencyAndAmount Rfnd;

        /// <summary>
        /// Element <b>SbcptIntrst</b> (Subscription Interest) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 33 )]
        public ActiveCurrencyAndAmount SbcptIntrst;

        /// <summary>
        /// Element <b>CshSttlmDtls</b> (Cash Settlement Details) of type PaymentTransaction24.
        /// </summary>
        [XmlElementAttribute( Order = 34 )]
        public PaymentTransaction24 CshSttlmDtls;

        /// <summary>
        /// Element <b>NonStdSttlmInf</b> (Non Std Settlement Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 35 )]
        public string NonStdSttlmInf;

        /// <summary>
        /// Element <b>PrtlSttlmOfUnits</b> (Partial Settlement Of Units) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 36 )]
        public decimal PrtlSttlmOfUnits;

        /// <summary>
        /// Element <b>PrtlSttlmOfUnitsSpecified</b> (Partial Settlement Of Units Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PrtlSttlmOfUnitsSpecified;

        /// <summary>
        /// Element <b>PrtlSttlmOfCsh</b> (Partial Settlement Of Cash) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 37 )]
        public decimal PrtlSttlmOfCsh;

        /// <summary>
        /// Element <b>PrtlSttlmOfCshSpecified</b> (Partial Settlement Of Cash Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PrtlSttlmOfCshSpecified;

        /// <summary>
        /// Element <b>StffClntBrkdwn</b> (Stff Client Breakdown) of type array of InvestmentFundsOrderBreakdown1.
        /// </summary>
        [XmlElementAttribute( "StffClntBrkdwn", Order = 38 )]
        public InvestmentFundsOrderBreakdown1[] StffClntBrkdwn;

        /// <summary>
        /// Element <b>FinAdvc</b> (Financial Advc) of type FinancialAdvice1Code.
        /// </summary>
        [XmlElementAttribute( Order = 39 )]
        public FinancialAdvice1Code FinAdvc;

        /// <summary>
        /// Element <b>FinAdvcSpecified</b> (Financial Advc Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FinAdvcSpecified;

        /// <summary>
        /// Element <b>NgtdTrad</b> (Ngtd Trade) of type NegotiatedTrade1Code.
        /// </summary>
        [XmlElementAttribute( Order = 40 )]
        public NegotiatedTrade1Code NgtdTrad;

        /// <summary>
        /// Element <b>NgtdTradSpecified</b> (Ngtd Trade Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NgtdTradSpecified;

        /// <summary>
        /// Element <b>LateRpt</b> (Late Report) of type LateReport1Code.
        /// </summary>
        [XmlElementAttribute( Order = 41 )]
        public LateReport1Code LateRpt;

        /// <summary>
        /// Element <b>LateRptSpecified</b> (Late Report Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LateRptSpecified;

        /// <summary>
        /// Element <b>RltdPtyDtls</b> (Related Party Details) of type array of Intermediary9.
        /// </summary>
        [XmlElementAttribute( "RltdPtyDtls", Order = 42 )]
        public Intermediary9[] RltdPtyDtls;

        /// <summary>
        /// Element <b>Equlstn</b> (Equlstn) of type Equalisation1.
        /// </summary>
        [XmlElementAttribute( Order = 43 )]
        public Equalisation1 Equlstn;
    }

    /// <summary>
    /// Class <b>SubAccount1</b> (Sub Account 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class SubAccount1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentification1 Id;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nm;

        /// <summary>
        /// Element <b>Chrtc</b> (Chrtc) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Chrtc;
    }

    /// <summary>
    /// Enumeration <b>RoundingDirection2Code</b> (Rounding Direction 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum RoundingDirection2Code
    {

        /// <summary>
        /// <b>RDUP - Round Up</b>.
        /// </summary>
        RDUP,

        /// <summary>
        /// <b>RDWN - Round Down</b>.
        /// </summary>
        RDWN,
    }

    /// <summary>
    /// Enumeration <b>DeliveryReceiptType2Code</b> (Delivery Receipt Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum DeliveryReceiptType2Code
    {

        /// <summary>
        /// <b>FREE - Separate Settlement</b>.
        /// </summary>
        FREE,

        /// <summary>
        /// <b>APMT - Against Payment Settlement</b>.
        /// </summary>
        APMT,
    }

    /// <summary>
    /// Enumeration <b>BestExecution1Code</b> (Best Execution 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum BestExecution1Code
    {

        /// <summary>
        /// <b>BTEX - Best</b>.
        /// </summary>
        BTEX,
    }

    /// <summary>
    /// Enumeration <b>IncomePreference1Code</b> (Income Preference 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum IncomePreference1Code
    {

        /// <summary>
        /// <b>CASH - Cash Payment</b>.
        /// </summary>
        CASH,

        /// <summary>
        /// <b>DRIP - Dividend Reinvestment</b>.
        /// </summary>
        DRIP,
    }

    /// <summary>
    /// Enumeration <b>FinancialAdvice1Code</b> (Financial Advice 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum FinancialAdvice1Code
    {

        /// <summary>
        /// <b>RECE - Received</b>.
        /// </summary>
        RECE,

        /// <summary>
        /// <b>NREC - Not Received</b>.
        /// </summary>
        NREC,

        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
    }

    /// <summary>
    /// Enumeration <b>NegotiatedTrade1Code</b> (Negotiated Trade 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum NegotiatedTrade1Code
    {

        /// <summary>
        /// <b>NEGO - Negotiated</b>.
        /// </summary>
        NEGO,

        /// <summary>
        /// <b>NNGO - Not Negotiated</b>.
        /// </summary>
        NNGO,

        /// <summary>
        /// <b>UNKW - Unknown</b>.
        /// </summary>
        UNKW,
    }

    /// <summary>
    /// Enumeration <b>LateReport1Code</b> (Late Report 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum LateReport1Code
    {

        /// <summary>
        /// <b>LAT1 - Late</b>.
        /// </summary>
        LAT1,

        /// <summary>
        /// <b>LAT2 - Late Because Partial</b>.
        /// </summary>
        LAT2,
    }

    /// <summary>
    /// Class <b>GenericIdentification11</b> (Generic Identification 11).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class GenericIdentification11
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  IdTp of type PersonIdentificationType2Code 
        ///  XtndedIdTp of type string 
        /// </summary>
        [XmlElementAttribute( "IdTp", typeof( PersonIdentificationType2Code ), Order = 1 )]
        [XmlElementAttribute( "XtndedIdTp", typeof( string ), Order = 1 )]
        public object Item;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Issr;
    }

    /// <summary>
    /// Enumeration <b>PersonIdentificationType2Code</b> (Person Identification Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum PersonIdentificationType2Code
    {

        /// <summary>
        /// <b>PASS - Passport</b>.
        /// </summary>
        PASS,

        /// <summary>
        /// <b>CPFA - CPFAccount Number</b>.
        /// </summary>
        CPFA,

        /// <summary>
        /// <b>SRSA - Retirement Scheme</b>.
        /// </summary>
        SRSA,

        /// <summary>
        /// <b>NRIN - National Registration Identification Number</b>.
        /// </summary>
        NRIN,

        /// <summary>
        /// <b>DRLC - Drivers License Number</b>.
        /// </summary>
        DRLC,

        /// <summary>
        /// <b>SOCS - Social Security Number</b>.
        /// </summary>
        SOCS,

        /// <summary>
        /// <b>AREG - Alien Registration Number</b>.
        /// </summary>
        AREG,

        /// <summary>
        /// <b>IDCD - Identity Card Number</b>.
        /// </summary>
        IDCD,

        /// <summary>
        /// <b>EMID - Employer Identification Number</b>.
        /// </summary>
        EMID,
    }

    /// <summary>
    /// Class <b>CountryAndResidentialStatusType1</b> (Country And Residential Status Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class CountryAndResidentialStatusType1
    {

        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Ctry;

        /// <summary>
        /// Element <b>ResdtlSts</b> (Residential Status) of type ResidentialStatus1Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ResidentialStatus1Code ResdtlSts;
    }

    /// <summary>
    /// Enumeration <b>ResidentialStatus1Code</b> (Residential Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum ResidentialStatus1Code
    {

        /// <summary>
        /// <b>RESI - Resident</b>.
        /// </summary>
        RESI,

        /// <summary>
        /// <b>PRES - Permanent Resident</b>.
        /// </summary>
        PRES,

        /// <summary>
        /// <b>NRES - Non Resident</b>.
        /// </summary>
        NRES,
    }

    /// <summary>
    /// Class <b>IndividualPerson12</b> (Individual Person 12).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class IndividualPerson12
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>BirthDt</b> (Birth Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 1 )]
        public System.DateTime BirthDt;

        /// <summary>
        /// Element <b>BirthDtSpecified</b> (Birth Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BirthDtSpecified;

        /// <summary>
        /// Element <b>CtryAndResdtlSts</b> (Country And Residential Status) of type CountryAndResidentialStatusType1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public CountryAndResidentialStatusType1 CtryAndResdtlSts;

        /// <summary>
        /// Element <b>OthrId</b> (Other Identification) of type array of GenericIdentification11.
        /// </summary>
        [XmlElementAttribute( "OthrId", Order = 3 )]
        public GenericIdentification11[] OthrId;
    }

    /// <summary>
    /// Class <b>InvestmentAccount21</b> (Investment Account 21).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class InvestmentAccount21
    {

        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentification1 AcctId;

        /// <summary>
        /// Element <b>AcctNm</b> (Account Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string AcctNm;

        /// <summary>
        /// Element <b>AcctDsgnt</b> (Account Designation) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string AcctDsgnt;

        /// <summary>
        /// Element <b>OwnrId</b> (Owner Identification) of type array of PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( "OwnrId", Order = 3 )]
        public PartyIdentification2Choice[] OwnrId;

        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification2Choice AcctSvcr;

        /// <summary>
        /// Element <b>OrdrOrgtrElgblty</b> (Order Originator Elgblty) of type OrderOriginatorEligibility1Code.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public OrderOriginatorEligibility1Code OrdrOrgtrElgblty;

        /// <summary>
        /// Element <b>OrdrOrgtrElgbltySpecified</b> (Order Originator Elgblty Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OrdrOrgtrElgbltySpecified;

        /// <summary>
        /// Element <b>SubAcctDtls</b> (Sub Account Details) of type SubAccount1.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public SubAccount1 SubAcctDtls;
    }

    /// <summary>
    /// Class <b>PlaceOfTradeIdentification1Choice</b> (Place Of Trade Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class PlaceOfTradeIdentification1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "Ctry", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "OverTheCntr", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Pty", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Xchg", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public string Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType
    {

        /// <summary>
        /// <b>Ctry - ?undefined</b>.
        /// </summary>
        Ctry,

        /// <summary>
        /// <b>OverTheCntr - ?undefined</b>.
        /// </summary>
        OverTheCntr,

        /// <summary>
        /// <b>Pty - ?undefined</b>.
        /// </summary>
        Pty,

        /// <summary>
        /// <b>Xchg - ?undefined</b>.
        /// </summary>
        Xchg,
    }

    /// <summary>
    /// Class <b>SubscriptionMultipleExecution3</b> (Subscription Multiple Execution 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class SubscriptionMultipleExecution3
    {

        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string MstrRef;

        /// <summary>
        /// Element <b>PlcOfTrad</b> (Place Of Trade) of type PlaceOfTradeIdentification1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PlaceOfTradeIdentification1Choice PlcOfTrad;

        /// <summary>
        /// Element <b>OrdrDtTm</b> (Order Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public System.DateTime OrdrDtTm;

        /// <summary>
        /// Element <b>OrdrDtTmSpecified</b> (Order Date Time Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OrdrDtTmSpecified;

        /// <summary>
        /// Element <b>ReqdFutrTradDt</b> (Requested Future Trade Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 3 )]
        public System.DateTime ReqdFutrTradDt;

        /// <summary>
        /// Element <b>ReqdFutrTradDtSpecified</b> (Requested Future Trade Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ReqdFutrTradDtSpecified;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  CxlRght of type CancellationRight1Code 
        ///  XtndedCxlRght of type string 
        /// </summary>
        [XmlElementAttribute( "CxlRght", typeof( CancellationRight1Code ), Order = 4 )]
        [XmlElementAttribute( "XtndedCxlRght", typeof( string ), Order = 4 )]
        public object Item;

        /// <summary>
        /// Element <b>InvstmtAcctDtls</b> (Investment Account Details) of type InvestmentAccount21.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public InvestmentAccount21 InvstmtAcctDtls;

        /// <summary>
        /// Element <b>BnfcryDtls</b> (Beneficiary Details) of type IndividualPerson12.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public IndividualPerson12 BnfcryDtls;

        /// <summary>
        /// Element <b>IndvExctnDtls</b> (Individual Execution Details) of type array of SubscriptionExecution6.
        /// </summary>
        [XmlElementAttribute( "IndvExctnDtls", Order = 7 )]
        public SubscriptionExecution6[] IndvExctnDtls;

        /// <summary>
        /// Element <b>TtlSttlmAmt</b> (Total Settlement Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public ActiveCurrencyAndAmount TtlSttlmAmt;

        /// <summary>
        /// Element <b>CshSttlmDt</b> (Cash Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 9 )]
        public System.DateTime CshSttlmDt;

        /// <summary>
        /// Element <b>CshSttlmDtSpecified</b> (Cash Settlement Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CshSttlmDtSpecified;

        /// <summary>
        /// Element <b>BlkCshSttlmDtls</b> (Bulk Cash Settlement Details) of type PaymentTransaction24.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public PaymentTransaction24 BlkCshSttlmDtls;
    }

    /// <summary>
    /// Enumeration <b>CancellationRight1Code</b> (Cancellation Right 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public enum CancellationRight1Code
    {

        /// <summary>
        /// <b>VALI - Entitled</b>.
        /// </summary>
        VALI,

        /// <summary>
        /// <b>NOXO - Execution Only</b>.
        /// </summary>
        NOXO,

        /// <summary>
        /// <b>NOWA - Waiver Agreement</b>.
        /// </summary>
        NOWA,

        /// <summary>
        /// <b>NOIN - Institutional</b>.
        /// </summary>
        NOIN,
    }

    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01" )]
    public class AdditionalReference3
    {

        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Ref;

        /// <summary>
        /// Element <b>RefIssr</b> (Reference Issuer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification2Choice RefIssr;

        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string MsgNm;
    }
}
