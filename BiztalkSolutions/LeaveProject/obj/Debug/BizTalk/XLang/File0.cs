
#pragma warning disable 162

namespace LeaveProject
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(LeaveProject.__messagetype_LeaveProject_LeaveRequestSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class LeaveRequestSchemaPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public LeaveRequestSchemaPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public LeaveRequestSchemaPortType(LeaveRequestSchemaPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            LeaveRequestSchemaPortType p = new LeaveRequestSchemaPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(LeaveRequestSchemaPortType),
            typeof(__messagetype_LeaveProject_LeaveRequestSchema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(LeaveProject.__messagetype_LeaveProject_LeaveResponseSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class LeaveResponseSchemaPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public LeaveResponseSchemaPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public LeaveResponseSchemaPortType(LeaveResponseSchemaPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            LeaveResponseSchemaPortType p = new LeaveResponseSchemaPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(LeaveResponseSchemaPortType),
            typeof(__messagetype_LeaveProject_LeaveResponseSchema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(LeaveProject.__messagetype_LeaveProject_LeaveRequestSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ReceivedFromHR : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ReceivedFromHR(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ReceivedFromHR(ReceivedFromHR p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ReceivedFromHR p = new ReceivedFromHR(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ReceivedFromHR),
            typeof(__messagetype_LeaveProject_LeaveRequestSchema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(LeaveProject.__messagetype_LeaveProject_LeaveRequestSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SendToEmpPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendToEmpPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendToEmpPortType(SendToEmpPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendToEmpPortType p = new SendToEmpPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendToEmpPortType),
            typeof(__messagetype_LeaveProject_LeaveRequestSchema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    [Microsoft.XLANGs.BaseTypes.CorrelationTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        new string[] {
            "LeaveProject.CR_RequestID"
        }
    )]
    sealed internal class CorrelationType_1 : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new LeaveProject.CR_RequestID()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 373 "Y:\RameshBiztalkProject\BiztalkSolutions\LeaveProject\LeaveMainOrch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticConvoyAttribute(
        0,
        new System.Type[] { typeof(CorrelationType_1) }
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "LeaveRequestRecvPort", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(LeaveProject.LeaveRequestSchemaPortType),
            typeof(LeaveProject.LeaveResponseSchemaPortType),
            typeof(LeaveProject.LeaveRequestSchemaPortType),
            typeof(LeaveProject.ReceivedFromHR),
            typeof(LeaveProject.SendToEmpPortType)
        },
        new System.String[] {
            "LeaveRequestRecvPort",
            "LeaveAcceptSendPort",
            "LeaveRequestToHRPort",
            "ResponseFromHR",
            "SendToEmp"
        },
        new System.Type[] {
            null,
            null,
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class LeaveMainOrch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(LeaveMainOrch));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static LeaveMainOrch()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __LeaveMainOrch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public LeaveMainOrch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "LeaveMainOrch", tracker)
        {
            ConstructorHelper();
        }

        public LeaveMainOrch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "LeaveMainOrch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>42c9a755-7b3b-4ffd-a920-eeff216c77ca</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>52c02a01-adda-4162-98ab-d9945c92bb1b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ReceiveLeaveRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>3f0b88cd-1d58-4822-bda6-367da002edfa</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>0f464a80-4166-445e-8e0a-48fdf6b081c1</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>RuleAccept</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>beefe3e3-02af-4b63-93d1-cde68f5fae4d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessageAccept</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>e1c17cbb-866a-4799-a715-800e4de826ba</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>TransformToEmp</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>49f76294-e276-40a0-9f36-328d78d42cdf</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>f0495bfe-1e32-471f-b10f-0ee550a63be6</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>85ce1974-6b61-4e17-821e-04a55fb803e5</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>e16a7ba9-ca51-441b-a6f3-048a99a8237d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SendToEmp</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>ed8f6245-f902-49e1-a5e3-93cdd28a0cdd</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>e351ad4e-d9d0-40e0-b7e6-f98bcee15fdf</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SendToHR</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>c51d3a69-b6c9-4d1a-8c99-30f4bb134a4e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>700ccd36-4bf7-4fbc-b15a-609ca04f6996</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'LeaveMainOrch'</ActionName><IsAtomic>0</IsAtomic><Line>373</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>391</Line><Position>22</Position><ShapeID>'52c02a01-adda-4162-98ab-d9945c92bb1b'</ShapeID>
<Messages>
	<MsgInfo><name>MsgLeaveRequest</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>393</Line><Position>13</Position><ShapeID>'3f0b88cd-1d58-4822-bda6-367da002edfa'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>396</Line><Position>17</Position><ShapeID>'beefe3e3-02af-4b63-93d1-cde68f5fae4d'</ShapeID>
<Messages>
	<MsgInfo><name>MsgLeaveResponse</name><part>part</part><schema>LeaveProject.LeaveResponseSchema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>MsgLeaveRequest</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>402</Line><Position>17</Position><ShapeID>'e16a7ba9-ca51-441b-a6f3-048a99a8237d'</ShapeID>
<Messages>
	<MsgInfo><name>MsgLeaveResponse</name><part>part</part><schema>LeaveProject.LeaveResponseSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>407</Line><Position>17</Position><ShapeID>'e351ad4e-d9d0-40e0-b7e6-f98bcee15fdf'</ShapeID>
<Messages>
	<MsgInfo><name>MsgLeaveRequest</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>409</Line><Position>17</Position><ShapeID>'c51d3a69-b6c9-4d1a-8c99-30f4bb134a4e'</ShapeID>
<Messages>
	<MsgInfo><name>MsgLeaveRequest</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>411</Line><Position>17</Position><ShapeID>'700ccd36-4bf7-4fbc-b15a-609ca04f6996'</ShapeID>
<Messages>
	<MsgInfo><name>MsgLeaveRequest</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='e1c05f33-3d81-48e5-b85e-034c16bf79d5' LowerBound='1.1' HigherBound='80.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='LeaveProject' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='8d7d2f09-f5d6-4ffc-87ec-ebad874e09fd' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='LeaveRequestSchemaPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='2915c0d1-a07c-4208-9b65-71e207527c78' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='52e2f3f1-a4e9-4fac-ba6f-ab35d15fbd77' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.31'>
                    <om:Property Name='Ref' Value='LeaveProject.LeaveRequestSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='5088cc9b-1900-4666-bffd-24c366fb77c9' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='LeaveResponseSchemaPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='260430d1-ce80-41f7-8411-a95954fd918b' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='6c297ab6-5dd1-46de-8985-6b54ed1ed09e' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.32'>
                    <om:Property Name='Ref' Value='LeaveProject.LeaveResponseSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='e36617bb-5ac6-4630-bc27-08a9dcfa3de7' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceivedFromHR' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='2c657019-5897-4849-b361-2750182245bf' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='b8383e88-c4e3-44e9-a87d-d46dc58d6604' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.31'>
                    <om:Property Name='Ref' Value='LeaveProject.LeaveRequestSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='97dd3cca-d591-4019-b933-c68e8fd3c465' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendToEmpPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='1cb0c471-d2e6-492a-9c74-3c3db805283b' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='c98af642-d80e-4247-8ea6-768c0e84fbd7' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.31'>
                    <om:Property Name='Ref' Value='LeaveProject.LeaveRequestSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='ece5f49e-51d1-4c03-a925-34f13f3cc678' ParentLink='Module_ServiceDeclaration' LowerBound='36.1' HigherBound='79.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='LeaveMainOrch' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='CorrelationDeclaration' OID='a98ff2aa-1091-4cd9-b157-57dedf7bd7ea' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='Type' Value='LeaveProject.CorrelationType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Correlation_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='5f5cb1d7-9897-4ff5-9bda-7c08ed352672' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='55.82' HigherBound='55.106'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='52c02a01-adda-4162-98ab-d9945c92bb1b' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='7f3fc694-985a-4e69-906d-c2d55ef8305e' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='71.74' HigherBound='71.87'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='e351ad4e-d9d0-40e0-b7e6-f98bcee15fdf' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='5f5b24fc-6fe7-4e90-bb7b-66000ea84fc3' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='73.71' HigherBound='73.84'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='c51d3a69-b6c9-4d1a-8c99-30f4bb134a4e' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_3' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='483e1142-3f99-44f0-9e56-3353296685e8' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='Type' Value='LeaveProject.LeaveRequestSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MsgLeaveRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='52e4487d-8db0-4de2-976a-3c780bcdfcf7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='Type' Value='LeaveProject.LeaveResponseSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MsgLeaveResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='42c9a755-7b3b-4ffd-a920-eeff216c77ca' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='52c02a01-adda-4162-98ab-d9945c92bb1b' ParentLink='ServiceBody_Statement' LowerBound='54.1' HigherBound='56.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='LeaveRequestRecvPort' />
                    <om:Property Name='MessageName' Value='MsgLeaveRequest' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ReceiveLeaveRequest' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='3f0b88cd-1d58-4822-bda6-367da002edfa' ParentLink='ServiceBody_Statement' LowerBound='56.1' HigherBound='77.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='DecisionBranch' OID='0f464a80-4166-445e-8e0a-48fdf6b081c1' ParentLink='ReallyComplexStatement_Branch' LowerBound='57.13' HigherBound='68.1'>
                        <om:Property Name='Expression' Value='MsgLeaveRequest.Details.NoOfDays&gt;21' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='RuleAccept' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Construct' OID='beefe3e3-02af-4b63-93d1-cde68f5fae4d' ParentLink='ComplexStatement_Statement' LowerBound='59.1' HigherBound='65.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessageAccept' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='e1c17cbb-866a-4799-a715-800e4de826ba' ParentLink='ComplexStatement_Statement' LowerBound='62.1' HigherBound='64.1'>
                                <om:Property Name='ClassName' Value='LeaveProject.LeaveRequestToResponse' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='TransformToEmp' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='MessagePartRef' OID='49f76294-e276-40a0-9f36-328d78d42cdf' ParentLink='Transform_InputMessagePartRef' LowerBound='63.89' HigherBound='63.104'>
                                    <om:Property Name='MessageRef' Value='MsgLeaveRequest' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_1' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='f0495bfe-1e32-471f-b10f-0ee550a63be6' ParentLink='Transform_OutputMessagePartRef' LowerBound='63.32' HigherBound='63.48'>
                                    <om:Property Name='MessageRef' Value='MsgLeaveResponse' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='85ce1974-6b61-4e17-821e-04a55fb803e5' ParentLink='Construct_MessageRef' LowerBound='60.27' HigherBound='60.43'>
                                <om:Property Name='Ref' Value='MsgLeaveResponse' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='e16a7ba9-ca51-441b-a6f3-048a99a8237d' ParentLink='ComplexStatement_Statement' LowerBound='65.1' HigherBound='67.1'>
                            <om:Property Name='PortName' Value='LeaveAcceptSendPort' />
                            <om:Property Name='MessageName' Value='MsgLeaveResponse' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='SendToEmp' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='ed8f6245-f902-49e1-a5e3-93cdd28a0cdd' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Send' OID='e351ad4e-d9d0-40e0-b7e6-f98bcee15fdf' ParentLink='ComplexStatement_Statement' LowerBound='70.1' HigherBound='72.1'>
                            <om:Property Name='PortName' Value='LeaveRequestToHRPort' />
                            <om:Property Name='MessageName' Value='MsgLeaveRequest' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='SendToHR' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Receive' OID='c51d3a69-b6c9-4d1a-8c99-30f4bb134a4e' ParentLink='ComplexStatement_Statement' LowerBound='72.1' HigherBound='74.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='ResponseFromHR' />
                            <om:Property Name='MessageName' Value='MsgLeaveRequest' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Send' OID='700ccd36-4bf7-4fbc-b15a-609ca04f6996' ParentLink='ComplexStatement_Statement' LowerBound='74.1' HigherBound='76.1'>
                            <om:Property Name='PortName' Value='SendToEmp' />
                            <om:Property Name='MessageName' Value='MsgLeaveRequest' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='ebcb245a-eb18-402c-94b2-a755e515ca08' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='39.1' HigherBound='41.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='LeaveProject.LeaveRequestSchemaPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LeaveRequestRecvPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='362bbaf5-ea1e-4ac4-aac4-9112c10ee4ec' ParentLink='PortDeclaration_CLRAttribute' LowerBound='39.1' HigherBound='40.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='fd373f41-6efc-4170-a7f7-9f9a207976e8' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='41.1' HigherBound='43.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='18' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='LeaveProject.LeaveResponseSchemaPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LeaveAcceptSendPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7981cd00-c5b3-4d8a-9b3b-4ce5bf4961fb' ParentLink='PortDeclaration_CLRAttribute' LowerBound='41.1' HigherBound='42.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='aa952b06-8c47-4196-a011-67e29afb0d09' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='43.1' HigherBound='45.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='11' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='LeaveProject.LeaveRequestSchemaPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LeaveRequestToHRPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='61b02738-5953-4e25-bda5-681911e8e176' ParentLink='PortDeclaration_CLRAttribute' LowerBound='43.1' HigherBound='44.1'>
                    <om:Property Name='PartnerPort' Value='LeaveRequestToHRPort' />
                    <om:Property Name='PartnerService' Value='LeaveProject.LeaveMainOrch' />
                    <om:Property Name='DirectBindingType' Value='PartnerPort' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='54b48856-f786-46ef-b002-0053b9c97ae1' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='45.1' HigherBound='47.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='LeaveProject.ReceivedFromHR' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ResponseFromHR' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='5b28472d-b5ef-44e6-8695-cbeab5c99ee7' ParentLink='PortDeclaration_CLRAttribute' LowerBound='45.1' HigherBound='46.1'>
                    <om:Property Name='PartnerPort' Value='ResponseFromHR' />
                    <om:Property Name='PartnerService' Value='LeaveProject.LeaveMainOrch' />
                    <om:Property Name='DirectBindingType' Value='PartnerPort' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='5a443dd9-b493-4480-ba4a-2aed3d52b67a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='47.1' HigherBound='49.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='LeaveProject.SendToEmpPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendToEmp' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='PhysicalBindingAttribute' OID='bb79b0ca-fa74-4ab7-98e3-9a67860bf5de' ParentLink='PortDeclaration_CLRAttribute' LowerBound='47.1' HigherBound='48.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLTransmit' />
                    <om:Property Name='TransportType' Value='FILE' />
                    <om:Property Name='URI' Value='C:\RameshBiztalkProject\BiztalkSolutions\FileDrop\SendToEmplFromHR\%MessageID%.xml' />
                    <om:Property Name='IsDynamic' Value='False' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='60758e34-48f0-49e7-a871-b51ffeb036a0' ParentLink='Module_CorrelationType' LowerBound='32.1' HigherBound='36.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PropertyRef' OID='f3915152-539b-4ce4-bc30-4fe2f1bf84a9' ParentLink='CorrelationType_PropertyRef' LowerBound='34.9' HigherBound='34.21'>
                <om:Property Name='Ref' Value='LeaveProject.CR_RequestID' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __LeaveMainOrch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __LeaveMainOrch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "LeaveMainOrch")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                LeaveMainOrch __svc__ = (LeaveMainOrch)_service;
                __LeaveMainOrch_root_0 __ctx0__ = (__LeaveMainOrch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.LeaveRequestRecvPort != null)
                {
                    __svc__.LeaveRequestRecvPort.Close(this, null);
                    __svc__.LeaveRequestRecvPort = null;
                }
                if (__svc__.LeaveAcceptSendPort != null)
                {
                    __svc__.LeaveAcceptSendPort.Close(this, null);
                    __svc__.LeaveAcceptSendPort = null;
                }
                if (__svc__.LeaveRequestToHRPort != null)
                {
                    __svc__.LeaveRequestToHRPort.Close(this, null);
                    __svc__.LeaveRequestToHRPort = null;
                }
                if (__svc__.ResponseFromHR != null)
                {
                    __svc__.ResponseFromHR.Close(this, null);
                    __svc__.ResponseFromHR = null;
                }
                if (__svc__.SendToEmp != null)
                {
                    __svc__.SendToEmp.Close(this, null);
                    __svc__.SendToEmp = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __LeaveMainOrch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __LeaveMainOrch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "LeaveMainOrch")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                LeaveMainOrch __svc__ = (LeaveMainOrch)_service;
                __LeaveMainOrch_1 __ctx1__ = (__LeaveMainOrch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__MsgLeaveRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgLeaveRequest);
                    __ctx1__.__MsgLeaveRequest = null;
                }
                if (__ctx1__ != null && __ctx1__.__MsgLeaveResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgLeaveResponse);
                    __ctx1__.__MsgLeaveResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__subWrapper1 != null)
                {
                    __ctx1__.__subWrapper1.Destroy(__svc__, __ctx1__);
                    __ctx1__.__subWrapper1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("MsgLeaveRequest")]
            public __messagetype_LeaveProject_LeaveRequestSchema __MsgLeaveRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("MsgLeaveResponse")]
            public __messagetype_LeaveProject_LeaveResponseSchema __MsgLeaveResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_1")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_1;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = new Microsoft.XLANGs.Core.CorrelationType[] { new CorrelationType_1() };
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return new object[] {
                    new Microsoft.XLANGs.Core.CorrelationType[] { _correlationTypes[0] }
                };
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("LeaveRequestRecvPort")]
        internal LeaveRequestSchemaPortType LeaveRequestRecvPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("LeaveAcceptSendPort")]
        internal LeaveResponseSchemaPortType LeaveAcceptSendPort;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute(typeof(LeaveMainOrch), "LeaveRequestToHRPort")]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("LeaveRequestToHRPort")]
        internal LeaveRequestSchemaPortType LeaveRequestToHRPort;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute(typeof(LeaveMainOrch), "ResponseFromHR")]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ResponseFromHR")]
        internal ReceivedFromHR ResponseFromHR;
        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute("FILE", "C:\\RameshBiztalkProject\\BiztalkSolutions\\FileDrop\\SendToEmplFromHR\\%MessageID%.xml", typeof(Microsoft.BizTalk.DefaultPipelines.XMLTransmit))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendToEmp")]
        internal SendToEmpPortType SendToEmp;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {LeaveRequestSchemaPortType.Operation_1},
                                               typeof(LeaveMainOrch).GetField("LeaveRequestRecvPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(LeaveMainOrch), "LeaveRequestRecvPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {LeaveResponseSchemaPortType.Operation_1},
                                               typeof(LeaveMainOrch).GetField("LeaveAcceptSendPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(LeaveMainOrch), "LeaveAcceptSendPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {LeaveRequestSchemaPortType.Operation_1},
                                               typeof(LeaveMainOrch).GetField("LeaveRequestToHRPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(LeaveMainOrch), "LeaveRequestToHRPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceivedFromHR.Operation_1},
                                               typeof(LeaveMainOrch).GetField("ResponseFromHR", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(LeaveMainOrch), "ResponseFromHR"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendToEmpPortType.Operation_1},
                                               typeof(LeaveMainOrch).GetField("SendToEmp", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(LeaveMainOrch), "SendToEmp"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                h[_portInfo[3].Name] = _portInfo[3];
                h[_portInfo[4].Name] = _portInfo[4];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , 0, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "52c02a01-adda-4162-98ab-d9945c92bb1b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "52c02a01-adda-4162-98ab-d9945c92bb1b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "3f0b88cd-1d58-4822-bda6-367da002edfa", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "beefe3e3-02af-4b63-93d1-cde68f5fae4d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "beefe3e3-02af-4b63-93d1-cde68f5fae4d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "e16a7ba9-ca51-441b-a6f3-048a99a8237d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "e16a7ba9-ca51-441b-a6f3-048a99a8237d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "e351ad4e-d9d0-40e0-b7e6-f98bcee15fdf", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "e351ad4e-d9d0-40e0-b7e6-f98bcee15fdf", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "c51d3a69-b6c9-4d1a-8c99-30f4bb134a4e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "c51d3a69-b6c9-4d1a-8c99-30f4bb134a4e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "700ccd36-4bf7-4fbc-b15a-609ca04f6996", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "700ccd36-4bf7-4fbc-b15a-609ca04f6996", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "3f0b88cd-1d58-4822-bda6-367da002edfa", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,15,15,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,4,5,6,6,6,7,3,8,8,8,9,10,10,11,12,12,12,13,14,15,15,15,15,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __LeaveMainOrch_root_0 __ctx0__ = (__LeaveMainOrch_root_0)_stateMgrs[0];
            __LeaveMainOrch_1 __ctx1__ = (__LeaveMainOrch_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                LeaveRequestRecvPort = new LeaveRequestSchemaPortType(0, this);
                LeaveAcceptSendPort = new LeaveResponseSchemaPortType(1, this);
                LeaveRequestToHRPort = new LeaveRequestSchemaPortType(2, this);
                ResponseFromHR = new ReceivedFromHR(3, this);
                SendToEmp = new SendToEmpPortType(4, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], LeaveRequestRecvPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __LeaveMainOrch_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __LeaveMainOrch_root_0 __ctx0__ = (__LeaveMainOrch_root_0)_stateMgrs[0];
            __LeaveMainOrch_1 __ctx1__ = (__LeaveMainOrch_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(1, System.Guid.Empty, ResponseFromHR, 0, __ctx0__);
                __ctx1__.__Correlation_1 = new Microsoft.XLANGs.Core.Correlation(this, 0, 1);
                __ctx1__.__Correlation_1.AddSubscription(((__LeaveMainOrch_1)_stateMgrs[1]).__subWrapper1.getSubscription(this), __ctx1__);
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!LeaveRequestRecvPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__MsgLeaveRequest != null)
                    __ctx1__.UnrefMessage(__ctx1__.__MsgLeaveRequest);
                __ctx1__.__MsgLeaveRequest = new __messagetype_LeaveProject_LeaveRequestSchema("MsgLeaveRequest", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__MsgLeaveRequest);
                LeaveRequestRecvPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__MsgLeaveRequest, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (LeaveRequestRecvPort != null)
                {
                    LeaveRequestRecvPort.Close(__ctx1__, __seg__);
                    LeaveRequestRecvPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__MsgLeaveRequest);
                    __edata.PortName = @"LeaveRequestRecvPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __condition__ = (System.Int32)__ctx1__.__MsgLeaveRequest.part.GetDistinguishedField("Details.NoOfDays") > 21;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 15;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                {
                    __messagetype_LeaveProject_LeaveResponseSchema __MsgLeaveResponse = new __messagetype_LeaveProject_LeaveResponseSchema("MsgLeaveResponse", __ctx1__);

                    ApplyTransform(typeof(LeaveProject.LeaveRequestToResponse), new object[] {__MsgLeaveResponse.part}, new object[] {__ctx1__.__MsgLeaveRequest.part});

                    if (__ctx1__.__MsgLeaveResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__MsgLeaveResponse);
                    __ctx1__.__MsgLeaveResponse = __MsgLeaveResponse;
                    __ctx1__.RefMessage(__ctx1__.__MsgLeaveResponse);
                }
                __ctx1__.__MsgLeaveResponse.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__MsgLeaveResponse);
                    __edata.Messages.Add(__ctx1__.__MsgLeaveRequest);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                LeaveAcceptSendPort.SendMessage(0, __ctx1__.__MsgLeaveResponse, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__MsgLeaveResponse);
                    __edata.PortName = @"LeaveAcceptSendPort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__MsgLeaveResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgLeaveResponse);
                    __ctx1__.__MsgLeaveResponse = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                LeaveRequestToHRPort.SendMessage(0, __ctx1__.__MsgLeaveRequest, null, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__MsgLeaveRequest);
                    __edata.PortName = @"LeaveRequestToHRPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!ResponseFromHR.GetMessageId(__ctx1__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__MsgLeaveRequest != null)
                    __ctx1__.UnrefMessage(__ctx1__.__MsgLeaveRequest);
                __ctx1__.__MsgLeaveRequest = new __messagetype_LeaveProject_LeaveRequestSchema("MsgLeaveRequest", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__MsgLeaveRequest);
                ResponseFromHR.ReceiveMessage(0, __msgEnv__, __ctx1__.__MsgLeaveRequest, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__MsgLeaveRequest);
                    __edata.PortName = @"ResponseFromHR";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendToEmp.SendMessage(0, __ctx1__.__MsgLeaveRequest, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__MsgLeaveRequest);
                    __edata.PortName = @"SendToEmp";
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__subWrapper1 != null)
                {
                    __ctx1__.__subWrapper1.Destroy(this, __ctx1__);
                    __ctx1__.__subWrapper1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (__ctx1__ != null && __ctx1__.__MsgLeaveRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgLeaveRequest);
                    __ctx1__.__MsgLeaveRequest = null;
                }
                if (SendToEmp != null)
                {
                    SendToEmp.Close(__ctx1__, __seg__);
                    SendToEmp = null;
                }
                if (ResponseFromHR != null)
                {
                    ResponseFromHR.Close(__ctx1__, __seg__);
                    ResponseFromHR = null;
                }
                if (LeaveRequestToHRPort != null)
                {
                    LeaveRequestToHRPort.Close(__ctx1__, __seg__);
                    LeaveRequestToHRPort = null;
                }
                if (LeaveAcceptSendPort != null)
                {
                    LeaveAcceptSendPort.Close(__ctx1__, __seg__);
                    LeaveAcceptSendPort = null;
                }
                Tracker.FireEvent(__eventLocations[14],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 30;
            case 30:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{DAFB96A9-E7AB-4671-B427-A178FFC4EABC}"))
        };

    }
    //#line 133 "Y:\RameshBiztalkProject\BiztalkSolutions\LeaveProject\HRSubOrch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RecvFromEmpPort", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(LeaveProject.LeaveRequestSchemaPortType),
            typeof(LeaveProject.ReceivedFromHR)
        },
        new System.String[] {
            "RecvFromEmpPort",
            "SendToEmpPort"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
            typeof(LeaveProject.CalledOrch)
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class HRSubOrch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
                "LeaveProject.CalledOrch"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(HRSubOrch));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static HRSubOrch()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __HRSubOrch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public HRSubOrch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "HRSubOrch", tracker)
        {
            ConstructorHelper();
        }

        public HRSubOrch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "HRSubOrch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>a1806477-9b4a-42e6-a745-438d0aaff176</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>a00d3e08-73d6-49fe-bb40-456f01879f76</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>76b35307-d3e5-42b7-8bca-050c12bf736b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>7b734f14-2ceb-4932-9e97-00331c288479</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>acd449ad-71ae-487f-9e82-3976b47210dc</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>3283692e-5816-4ba0-a0a3-a306c9c3412d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>CallOrchestration_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>0afb079e-bc82-46b7-ad22-c359787de41d</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>MessageIn</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>b07a8448-e313-461e-83ea-ad6fa8edb893</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>MessageIn</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>0b31f67f-6289-4488-9ee4-f2209c0596cb</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'HRSubOrch'</ActionName><IsAtomic>0</IsAtomic><Line>133</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>144</Line><Position>22</Position><ShapeID>'a00d3e08-73d6-49fe-bb40-456f01879f76'</ShapeID>
<Messages>
	<MsgInfo><name>MessageIn</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>146</Line><Position>13</Position><ShapeID>'76b35307-d3e5-42b7-8bca-050c12bf736b'</ShapeID>
<Messages>
	<MsgInfo><name>MessageOut</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>153</Line><Position>42</Position><ShapeID>'3283692e-5816-4ba0-a0a3-a306c9c3412d'</ShapeID>
<Messages>
	<MsgInfo><name>MessageIn</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>MessageIn</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>155</Line><Position>13</Position><ShapeID>'0b31f67f-6289-4488-9ee4-f2209c0596cb'</ShapeID>
<Messages>
	<MsgInfo><name>MessageOut</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='063b9b01-abf5-47d3-9e32-d643e18fb216' LowerBound='1.1' HigherBound='31.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='LeaveProject' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='acc547e1-a12d-4d7f-aeba-cb196f51a04c' ParentLink='Module_ServiceDeclaration' LowerBound='4.1' HigherBound='30.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='HRSubOrch' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='0ee46915-e805-4bd2-aa8e-0990a8b28434' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='11.1' HigherBound='12.1'>
                <om:Property Name='Type' Value='LeaveProject.LeaveRequestSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessageIn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7d434af4-75c9-41eb-86b1-2dcfd2e25278' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='12.1' HigherBound='13.1'>
                <om:Property Name='Type' Value='LeaveProject.LeaveRequestSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessageOut' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='a1806477-9b4a-42e6-a745-438d0aaff176' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='a00d3e08-73d6-49fe-bb40-456f01879f76' ParentLink='ServiceBody_Statement' LowerBound='15.1' HigherBound='17.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RecvFromEmpPort' />
                    <om:Property Name='MessageName' Value='MessageIn' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='76b35307-d3e5-42b7-8bca-050c12bf736b' ParentLink='ServiceBody_Statement' LowerBound='17.1' HigherBound='24.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='7b734f14-2ceb-4932-9e97-00331c288479' ParentLink='ComplexStatement_Statement' LowerBound='20.1' HigherBound='23.1'>
                        <om:Property Name='Expression' Value='MessageOut=MessageIn;&#xD;&#xA;MessageOut.Details.Reason=&quot;Modified by HR Sub Orch&quot;;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='acd449ad-71ae-487f-9e82-3976b47210dc' ParentLink='Construct_MessageRef' LowerBound='18.23' HigherBound='18.33'>
                        <om:Property Name='Ref' Value='MessageOut' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Call' OID='3283692e-5816-4ba0-a0a3-a306c9c3412d' ParentLink='ServiceBody_Statement' LowerBound='24.1' HigherBound='26.1'>
                    <om:Property Name='Identifier' Value='CallOrchestration_1' />
                    <om:Property Name='Invokee' Value='LeaveProject.CalledOrch' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='CallOrchestration_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Parameter' OID='0afb079e-bc82-46b7-ad22-c359787de41d' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='MessageIn' />
                        <om:Property Name='Type' Value='LeaveProject.LeaveRequestSchema' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='b07a8448-e313-461e-83ea-ad6fa8edb893' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='Out' />
                        <om:Property Name='Name' Value='MessageIn' />
                        <om:Property Name='Type' Value='LeaveProject.LeaveRequestSchema' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='0b31f67f-6289-4488-9ee4-f2209c0596cb' ParentLink='ServiceBody_Statement' LowerBound='26.1' HigherBound='28.1'>
                    <om:Property Name='PortName' Value='SendToEmpPort' />
                    <om:Property Name='MessageName' Value='MessageOut' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e6ac5234-f5c9-41aa-bfc5-a671ec322032' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='7.1' HigherBound='9.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='LeaveProject.LeaveRequestSchemaPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RecvFromEmpPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='4cf5e49d-7d77-43b5-a838-68a5b3f8e3a0' ParentLink='PortDeclaration_CLRAttribute' LowerBound='7.1' HigherBound='8.1'>
                    <om:Property Name='PartnerPort' Value='LeaveRequestToHRPort' />
                    <om:Property Name='PartnerService' Value='LeaveProject.LeaveMainOrch' />
                    <om:Property Name='DirectBindingType' Value='PartnerPort' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='abb76102-d66d-4288-9c90-66fc811caeac' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='9.1' HigherBound='11.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='LeaveProject.ReceivedFromHR' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendToEmpPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='67e09b98-c49c-4588-a638-94617e8d70c0' ParentLink='PortDeclaration_CLRAttribute' LowerBound='9.1' HigherBound='10.1'>
                    <om:Property Name='PartnerPort' Value='ResponseFromHR' />
                    <om:Property Name='PartnerService' Value='LeaveProject.LeaveMainOrch' />
                    <om:Property Name='DirectBindingType' Value='PartnerPort' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __HRSubOrch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __HRSubOrch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "HRSubOrch")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                HRSubOrch __svc__ = (HRSubOrch)_service;
                __HRSubOrch_root_0 __ctx0__ = (__HRSubOrch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SendToEmpPort != null)
                {
                    __svc__.SendToEmpPort.Close(this, null);
                    __svc__.SendToEmpPort = null;
                }
                if (__svc__.RecvFromEmpPort != null)
                {
                    __svc__.RecvFromEmpPort.Close(this, null);
                    __svc__.RecvFromEmpPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __HRSubOrch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __HRSubOrch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "HRSubOrch")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                HRSubOrch __svc__ = (HRSubOrch)_service;
                __HRSubOrch_1 __ctx1__ = (__HRSubOrch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__MessageIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MessageIn);
                    __ctx1__.__MessageIn = null;
                }
                if (__ctx1__ != null && __ctx1__.__MessageOut != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MessageOut);
                    __ctx1__.__MessageOut = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("MessageIn")]
            public __messagetype_LeaveProject_LeaveRequestSchema __MessageIn;
            [Microsoft.XLANGs.Core.UserVariableAttribute("MessageOut")]
            public __messagetype_LeaveProject_LeaveRequestSchema __MessageOut;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute(typeof(LeaveMainOrch), "LeaveRequestToHRPort")]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RecvFromEmpPort")]
        internal LeaveRequestSchemaPortType RecvFromEmpPort;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute(typeof(LeaveMainOrch), "ResponseFromHR")]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendToEmpPort")]
        internal ReceivedFromHR SendToEmpPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {LeaveRequestSchemaPortType.Operation_1},
                                               typeof(HRSubOrch).GetField("RecvFromEmpPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(HRSubOrch), "RecvFromEmpPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceivedFromHR.Operation_1},
                                               typeof(HRSubOrch).GetField("SendToEmpPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(HRSubOrch), "SendToEmpPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                    typeof(LeaveProject.CalledOrch)                    
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "a00d3e08-73d6-49fe-bb40-456f01879f76", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "a00d3e08-73d6-49fe-bb40-456f01879f76", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "76b35307-d3e5-42b7-8bca-050c12bf736b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "76b35307-d3e5-42b7-8bca-050c12bf736b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "3283692e-5816-4ba0-a0a3-a306c9c3412d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "3283692e-5816-4ba0-a0a3-a306c9c3412d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "0b31f67f-6289-4488-9ee4-f2209c0596cb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "0b31f67f-6289-4488-9ee4-f2209c0596cb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,9,9,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,6,7,7,7,8,9,9,9,9,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __HRSubOrch_1 __ctx1__ = (__HRSubOrch_1)_stateMgrs[1];
            __HRSubOrch_root_0 __ctx0__ = (__HRSubOrch_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                RecvFromEmpPort = new LeaveRequestSchemaPortType(0, this);
                SendToEmpPort = new ReceivedFromHR(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RecvFromEmpPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __HRSubOrch_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __HRSubOrch_1 __ctx1__ = (__HRSubOrch_1)_stateMgrs[1];
            __HRSubOrch_root_0 __ctx0__ = (__HRSubOrch_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!RecvFromEmpPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__MessageIn != null)
                    __ctx1__.UnrefMessage(__ctx1__.__MessageIn);
                __ctx1__.__MessageIn = new __messagetype_LeaveProject_LeaveRequestSchema("MessageIn", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__MessageIn);
                RecvFromEmpPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__MessageIn, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RecvFromEmpPort != null)
                {
                    RecvFromEmpPort.Close(__ctx1__, __seg__);
                    RecvFromEmpPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__MessageIn);
                    __edata.PortName = @"RecvFromEmpPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_LeaveProject_LeaveRequestSchema __MessageOut = new __messagetype_LeaveProject_LeaveRequestSchema("MessageOut", __ctx1__);

                    __MessageOut.CopyFrom(__ctx1__.__MessageIn);
                    __MessageOut.part.SetDistinguishedField("Details.Reason", "Modified by HR Sub Orch");

                    if (__ctx1__.__MessageOut != null)
                        __ctx1__.UnrefMessage(__ctx1__.__MessageOut);
                    __ctx1__.__MessageOut = __MessageOut;
                    __ctx1__.RefMessage(__ctx1__.__MessageOut);
                }
                __ctx1__.__MessageOut.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__MessageOut);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                {
                    Microsoft.XLANGs.Core.Service svc = new LeaveProject.CalledOrch(2, InstanceId, this);
                    _stateMgrs[2] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[5],new object[] {__ctx1__.__MessageIn, new Microsoft.XLANGs.Core.MessageTuple((Microsoft.XLANGs.Core.Context)_stateMgrs[1], null)});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 10:
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[2]).Args;
                    __ctx1__.__MessageIn = (__messagetype_LeaveProject_LeaveRequestSchema)((Microsoft.XLANGs.Core.MessageTuple)(args[1])).message;
                    __ctx1__.__MessageIn.MessageName = "MessageIn";
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx1__.__MessageIn);
                    __edata.Messages.Add(__ctx1__.__MessageIn);
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__MessageIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MessageIn);
                    __ctx1__.__MessageIn = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendToEmpPort.SendMessage(0, __ctx1__.__MessageOut, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendToEmpPort != null)
                {
                    SendToEmpPort.Close(__ctx1__, __seg__);
                    SendToEmpPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__MessageOut);
                    __edata.PortName = @"SendToEmpPort";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__MessageOut != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MessageOut);
                    __ctx1__.__MessageOut = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 18;
            case 18:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 57 "Y:\RameshBiztalkProject\BiztalkSolutions\LeaveProject\CalledOrch.odx"
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class CalledOrch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] LeaveProject.LeaveRequestSchema MessageIN,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] out LeaveProject.LeaveRequestSchema MessageOut)
        {
            MessageOut = default(LeaveProject.LeaveRequestSchema);
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(CalledOrch));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static CalledOrch()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __CalledOrch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public CalledOrch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "CalledOrch", tracker)
        {
            ConstructorHelper();
        }

        public CalledOrch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "CalledOrch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>57e4e067-5f55-4818-8bbc-74367a5af816</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>79becbdd-ca30-4fd9-a034-dfc4e9c7084b</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>MessageIN</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>e33e0b97-400a-46e2-8836-745e2d77fa44</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>MessageOut</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>d113b55a-6753-4b2d-acc6-795a533685bd</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>dd8d9a38-b80d-4eac-8393-87a0faea8858</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a8c9028e-03c4-4f0d-b1bc-7f1e97cbfc94</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'CalledOrch'</ActionName><IsAtomic>0</IsAtomic><Line>57</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
	<MsgInfo><name>MessageIN</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>MessageOut</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>62</Line><Position>13</Position><ShapeID>'d113b55a-6753-4b2d-acc6-795a533685bd'</ShapeID>
<Messages>
	<MsgInfo><name>MessageOut</name><part>part</part><schema>LeaveProject.LeaveRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='192fdf98-d0d6-4639-b142-c5d9102a7fd9' LowerBound='1.1' HigherBound='19.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='LeaveProject' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='20636f3c-9f16-4a82-9502-4203678d5366' ParentLink='Module_ServiceDeclaration' LowerBound='4.1' HigherBound='18.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CalledOrch' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='57e4e067-5f55-4818-8bbc-74367a5af816' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageDeclaration' OID='79becbdd-ca30-4fd9-a034-dfc4e9c7084b' ParentLink='ServiceBody_Declaration' LowerBound='7.15' HigherBound='7.51'>
                    <om:Property Name='Type' Value='LeaveProject.LeaveRequestSchema' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='MessageIN' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='e33e0b97-400a-46e2-8836-745e2d77fa44' ParentLink='ServiceBody_Declaration' LowerBound='7.53' HigherBound='7.94'>
                    <om:Property Name='Type' Value='LeaveProject.LeaveRequestSchema' />
                    <om:Property Name='ParamDirection' Value='Out' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='MessageOut' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='d113b55a-6753-4b2d-acc6-795a533685bd' ParentLink='ServiceBody_Statement' LowerBound='9.1' HigherBound='16.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='dd8d9a38-b80d-4eac-8393-87a0faea8858' ParentLink='ComplexStatement_Statement' LowerBound='12.1' HigherBound='15.1'>
                        <om:Property Name='Expression' Value='MessageOut=MessageIN;&#xD;&#xA;MessageOut.Details.Reason=&quot;Modifeid by Called Orch&quot;;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='a8c9028e-03c4-4f0d-b1bc-7f1e97cbfc94' ParentLink='Construct_MessageRef' LowerBound='10.23' HigherBound='10.33'>
                        <om:Property Name='Ref' Value='MessageOut' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __CalledOrch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __CalledOrch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CalledOrch")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                CalledOrch __svc__ = (CalledOrch)_service;
                base.Finally();
            }

        }


        [System.SerializableAttribute]
        public class __CalledOrch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __CalledOrch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CalledOrch")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                CalledOrch __svc__ = (CalledOrch)_service;
                __CalledOrch_1 __ctx1__ = (__CalledOrch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__MessageIN != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MessageIN);
                    __ctx1__.__MessageIN = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("MessageIN")]
            public __messagetype_LeaveProject_LeaveRequestSchema __MessageIN;
            [Microsoft.XLANGs.Core.UserVariableAttribute("MessageOut")]
            public __messagetype_LeaveProject_LeaveRequestSchema __MessageOut;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }


        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] { };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return null; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "d113b55a-6753-4b2d-acc6-795a533685bd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "d113b55a-6753-4b2d-acc6-795a533685bd", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,2,2,3,1,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __CalledOrch_root_0 __ctx0__ = (__CalledOrch_root_0)_stateMgrs[0];
            __CalledOrch_1 __ctx1__ = (__CalledOrch_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __CalledOrch_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __CalledOrch_root_0 __ctx0__ = (__CalledOrch_root_0)_stateMgrs[0];
            __CalledOrch_1 __ctx1__ = (__CalledOrch_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__MessageIN = new __messagetype_LeaveProject_LeaveRequestSchema("MessageIN", __ctx1__);
                __ctx1__.__MessageIN.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[0]);
                __ctx1__.RefMessage(__ctx1__.__MessageIN);
                __ctx1__.__MessageIN.ConstructionCompleteEvent();
                __ctx1__.__MessageOut = null;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                {
                    __messagetype_LeaveProject_LeaveRequestSchema __MessageOut = new __messagetype_LeaveProject_LeaveRequestSchema("MessageOut", __ctx1__);

                    __MessageOut.CopyFrom(__ctx1__.__MessageIN);
                    __MessageOut.part.SetDistinguishedField("Details.Reason", "Modifeid by Called Orch");

                    if (__ctx1__.__MessageOut != null)
                        __ctx1__.UnrefMessage(__ctx1__.__MessageOut);
                    __ctx1__.__MessageOut = __MessageOut;
                    __ctx1__.RefMessage(__ctx1__.__MessageOut);
                }
                __ctx1__.__MessageOut.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__MessageOut);
                    Tracker.FireEvent(__eventLocations[3],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body);
                    __edata.Messages.Add(__ctx1__.__MessageIN);
                    __edata.Messages.Add(__ctx1__.__MessageOut);
                    Tracker.FireEvent(__eventLocations[0],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__MessageIN != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MessageIN);
                    __ctx1__.__MessageIN = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 9;
            case 9:
                ((Microsoft.XLANGs.Core.MessageTuple)(Args[1])).message = __ctx1__.__MessageOut;
                ((Microsoft.XLANGs.Core.MessageTuple)(Args[1])).context.RefMessage(__ctx1__.__MessageOut);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __LeaveProject_LeaveRequestSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static LeaveProject.LeaveRequestSchema _schema = new LeaveProject.LeaveRequestSchema();

        public __LeaveProject_LeaveRequestSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "LeaveProject.LeaveRequestSchema",
        new System.Type[]{
            typeof(LeaveProject.LeaveRequestSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__LeaveProject_LeaveRequestSchema__)
        },
        0,
        @"http://LeaveProject.LeaveRequestSchema#LeaveRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_LeaveProject_LeaveRequestSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __LeaveProject_LeaveRequestSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __LeaveProject_LeaveRequestSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_LeaveProject_LeaveRequestSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __LeaveProject_LeaveResponseSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static LeaveProject.LeaveResponseSchema _schema = new LeaveProject.LeaveResponseSchema();

        public __LeaveProject_LeaveResponseSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "LeaveProject.LeaveResponseSchema",
        new System.Type[]{
            typeof(LeaveProject.LeaveResponseSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__LeaveProject_LeaveResponseSchema__)
        },
        0,
        @"http://LeaveProject.LeaveResponseSchema#LeaveResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_LeaveProject_LeaveResponseSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __LeaveProject_LeaveResponseSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __LeaveProject_LeaveResponseSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_LeaveProject_LeaveResponseSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
