namespace tora_asia.leaverequest.Workflows.LeaveReqeustWF {
    
    #line 18 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWFV1\Workflow.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWFV1\Workflow.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 19 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWFV1\Workflow.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWFV1\Workflow.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWFV1\Workflow.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWFV1\Workflow.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 20 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWFV1\Workflow.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 21 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWFV1\Workflow.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 22 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWFV1\Workflow.xaml"
    using System.Collections.ObjectModel;
    
    #line default
    #line hidden
    
    #line 23 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWFV1\Workflow.xaml"
    using Microsoft.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWFV1\Workflow.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Workflow : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = Workflow_TypedDataContext4.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext4(locations, activityContext, true);
                }
                Workflow_TypedDataContext4 refDataContext0 = ((Workflow_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<string>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext4(locations, activityContext, true);
                }
                Workflow_TypedDataContext4 refDataContext1 = ((Workflow_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext1.GetLocation<int>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext4(locations, activityContext, true);
                }
                Workflow_TypedDataContext4 refDataContext2 = ((Workflow_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext2.GetLocation<string>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext4(locations, activityContext, true);
                }
                Workflow_TypedDataContext4 refDataContext3 = ((Workflow_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext4_ForReadOnly valDataContext4 = ((Workflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext4(locations, activityContext, true);
                }
                Workflow_TypedDataContext4 refDataContext5 = ((Workflow_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext5.GetLocation<System.Guid>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext4_ForReadOnly valDataContext6 = ((Workflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow_TypedDataContext6(locations, activityContext, true);
                }
                Workflow_TypedDataContext6 refDataContext7 = ((Workflow_TypedDataContext6)(cachedCompiledDataContext[2]));
                return refDataContext7.GetLocation<int>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow_TypedDataContext6(locations, activityContext, true);
                }
                Workflow_TypedDataContext6 refDataContext8 = ((Workflow_TypedDataContext6)(cachedCompiledDataContext[2]));
                return refDataContext8.GetLocation<bool>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext9 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext10 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext7(locations, activityContext, true);
                }
                Workflow_TypedDataContext7 refDataContext11 = ((Workflow_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext11.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext12 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext13 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext14 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext15 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext16 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext17 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow_TypedDataContext8(locations, activityContext, true);
                }
                Workflow_TypedDataContext8 refDataContext18 = ((Workflow_TypedDataContext8)(cachedCompiledDataContext[6]));
                return refDataContext18.GetLocation<int>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext19 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext20 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext21 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext22 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext23 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext24 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext25 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow_TypedDataContext8(locations, activityContext, true);
                }
                Workflow_TypedDataContext8 refDataContext26 = ((Workflow_TypedDataContext8)(cachedCompiledDataContext[6]));
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow_TypedDataContext8(locations, activityContext, true);
                }
                Workflow_TypedDataContext8 refDataContext27 = ((Workflow_TypedDataContext8)(cachedCompiledDataContext[6]));
                return refDataContext27.GetLocation<string>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow_TypedDataContext8(locations, activityContext, true);
                }
                Workflow_TypedDataContext8 refDataContext28 = ((Workflow_TypedDataContext8)(cachedCompiledDataContext[6]));
                return refDataContext28.GetLocation<string>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow_TypedDataContext8(locations, activityContext, true);
                }
                Workflow_TypedDataContext8 refDataContext29 = ((Workflow_TypedDataContext8)(cachedCompiledDataContext[6]));
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow_TypedDataContext8(locations, activityContext, true);
                }
                Workflow_TypedDataContext8 refDataContext30 = ((Workflow_TypedDataContext8)(cachedCompiledDataContext[6]));
                return refDataContext30.GetLocation<string>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext31 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext7(locations, activityContext, true);
                }
                Workflow_TypedDataContext7 refDataContext32 = ((Workflow_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext32.GetLocation<string>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext7(locations, activityContext, true);
                }
                Workflow_TypedDataContext7 refDataContext33 = ((Workflow_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext33.GetLocation<string>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext7(locations, activityContext, true);
                }
                Workflow_TypedDataContext7 refDataContext34 = ((Workflow_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext34.GetLocation<string>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext7(locations, activityContext, true);
                }
                Workflow_TypedDataContext7 refDataContext35 = ((Workflow_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext35.GetLocation<string>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext36 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext37 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext38 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext7(locations, activityContext, true);
                }
                Workflow_TypedDataContext7 refDataContext39 = ((Workflow_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext39.GetLocation<bool>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext40 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow_TypedDataContext9(locations, activityContext, true);
                }
                Workflow_TypedDataContext9 refDataContext41 = ((Workflow_TypedDataContext9)(cachedCompiledDataContext[8]));
                return refDataContext41.GetLocation<int>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow_TypedDataContext9(locations, activityContext, true);
                }
                Workflow_TypedDataContext9 refDataContext42 = ((Workflow_TypedDataContext9)(cachedCompiledDataContext[8]));
                return refDataContext42.GetLocation<int>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext43 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow_TypedDataContext9(locations, activityContext, true);
                }
                Workflow_TypedDataContext9 refDataContext44 = ((Workflow_TypedDataContext9)(cachedCompiledDataContext[8]));
                return refDataContext44.GetLocation<int>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext45 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext46 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext47 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext48 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow_TypedDataContext9(locations, activityContext, true);
                }
                Workflow_TypedDataContext9 refDataContext49 = ((Workflow_TypedDataContext9)(cachedCompiledDataContext[8]));
                return refDataContext49.GetLocation<int>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext50 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow_TypedDataContext6(locations, activityContext, true);
                }
                Workflow_TypedDataContext6 refDataContext51 = ((Workflow_TypedDataContext6)(cachedCompiledDataContext[2]));
                return refDataContext51.GetLocation<int>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow_TypedDataContext6(locations, activityContext, true);
                }
                Workflow_TypedDataContext6 refDataContext52 = ((Workflow_TypedDataContext6)(cachedCompiledDataContext[2]));
                return refDataContext52.GetLocation<bool>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext6_ForReadOnly valDataContext53 = ((Workflow_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext6_ForReadOnly valDataContext54 = ((Workflow_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext6_ForReadOnly valDataContext55 = ((Workflow_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext6_ForReadOnly valDataContext56 = ((Workflow_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext12_ForReadOnly valDataContext57 = ((Workflow_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext12(locations, activityContext, true);
                }
                Workflow_TypedDataContext12 refDataContext58 = ((Workflow_TypedDataContext12)(cachedCompiledDataContext[11]));
                return refDataContext58.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext12_ForReadOnly valDataContext59 = ((Workflow_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext12(locations, activityContext, true);
                }
                Workflow_TypedDataContext12 refDataContext60 = ((Workflow_TypedDataContext12)(cachedCompiledDataContext[11]));
                return refDataContext60.GetLocation<string>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext12(locations, activityContext, true);
                }
                Workflow_TypedDataContext12 refDataContext61 = ((Workflow_TypedDataContext12)(cachedCompiledDataContext[11]));
                return refDataContext61.GetLocation<string>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext12(locations, activityContext, true);
                }
                Workflow_TypedDataContext12 refDataContext62 = ((Workflow_TypedDataContext12)(cachedCompiledDataContext[11]));
                return refDataContext62.GetLocation<double>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext12_ForReadOnly valDataContext63 = ((Workflow_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext12(locations, activityContext, true);
                }
                Workflow_TypedDataContext12 refDataContext64 = ((Workflow_TypedDataContext12)(cachedCompiledDataContext[11]));
                return refDataContext64.GetLocation<string>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext12(locations, activityContext, true);
                }
                Workflow_TypedDataContext12 refDataContext65 = ((Workflow_TypedDataContext12)(cachedCompiledDataContext[11]));
                return refDataContext65.GetLocation<string>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext12(locations, activityContext, true);
                }
                Workflow_TypedDataContext12 refDataContext66 = ((Workflow_TypedDataContext12)(cachedCompiledDataContext[11]));
                return refDataContext66.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext12(locations, activityContext, true);
                }
                Workflow_TypedDataContext12 refDataContext67 = ((Workflow_TypedDataContext12)(cachedCompiledDataContext[11]));
                return refDataContext67.GetLocation<string>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext12(locations, activityContext, true);
                }
                Workflow_TypedDataContext12 refDataContext68 = ((Workflow_TypedDataContext12)(cachedCompiledDataContext[11]));
                return refDataContext68.GetLocation<string>(refDataContext68.ValueType___Expr68Get, refDataContext68.ValueType___Expr68Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext12_ForReadOnly valDataContext69 = ((Workflow_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext12_ForReadOnly valDataContext70 = ((Workflow_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext12(locations, activityContext, true);
                }
                Workflow_TypedDataContext12 refDataContext71 = ((Workflow_TypedDataContext12)(cachedCompiledDataContext[11]));
                return refDataContext71.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext12_ForReadOnly valDataContext72 = ((Workflow_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext12_ForReadOnly valDataContext73 = ((Workflow_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext12_ForReadOnly valDataContext74 = ((Workflow_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Workflow_TypedDataContext13(locations, activityContext, true);
                }
                Workflow_TypedDataContext13 refDataContext75 = ((Workflow_TypedDataContext13)(cachedCompiledDataContext[12]));
                return refDataContext75.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Workflow_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext13_ForReadOnly valDataContext76 = ((Workflow_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Workflow_TypedDataContext13(locations, activityContext, true);
                }
                Workflow_TypedDataContext13 refDataContext77 = ((Workflow_TypedDataContext13)(cachedCompiledDataContext[12]));
                return refDataContext77.GetLocation<string>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Workflow_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext13_ForReadOnly valDataContext78 = ((Workflow_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Workflow_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext13_ForReadOnly valDataContext79 = ((Workflow_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext79.ValueType___Expr79Get();
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Workflow_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext13_ForReadOnly valDataContext80 = ((Workflow_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Workflow_TypedDataContext13(locations, activityContext, true);
                }
                Workflow_TypedDataContext13 refDataContext81 = ((Workflow_TypedDataContext13)(cachedCompiledDataContext[12]));
                return refDataContext81.GetLocation<string>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Workflow_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext11_ForReadOnly valDataContext82 = ((Workflow_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Workflow_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext11_ForReadOnly valDataContext83 = ((Workflow_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Workflow_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext14_ForReadOnly valDataContext84 = ((Workflow_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Workflow_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext14_ForReadOnly valDataContext85 = ((Workflow_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Workflow_TypedDataContext14(locations, activityContext, true);
                }
                Workflow_TypedDataContext14 refDataContext86 = ((Workflow_TypedDataContext14)(cachedCompiledDataContext[16]));
                return refDataContext86.GetLocation<string>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext17_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Workflow_TypedDataContext17_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext17_ForReadOnly valDataContext87 = ((Workflow_TypedDataContext17_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext17.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new Workflow_TypedDataContext17(locations, activityContext, true);
                }
                Workflow_TypedDataContext17 refDataContext88 = ((Workflow_TypedDataContext17)(cachedCompiledDataContext[18]));
                return refDataContext88.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext88.ValueType___Expr88Get, refDataContext88.ValueType___Expr88Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext17_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Workflow_TypedDataContext17_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext17_ForReadOnly valDataContext89 = ((Workflow_TypedDataContext17_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext17.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new Workflow_TypedDataContext17(locations, activityContext, true);
                }
                Workflow_TypedDataContext17 refDataContext90 = ((Workflow_TypedDataContext17)(cachedCompiledDataContext[18]));
                return refDataContext90.GetLocation<string>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext17.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new Workflow_TypedDataContext17(locations, activityContext, true);
                }
                Workflow_TypedDataContext17 refDataContext91 = ((Workflow_TypedDataContext17)(cachedCompiledDataContext[18]));
                return refDataContext91.GetLocation<string>(refDataContext91.ValueType___Expr91Get, refDataContext91.ValueType___Expr91Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext17.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new Workflow_TypedDataContext17(locations, activityContext, true);
                }
                Workflow_TypedDataContext17 refDataContext92 = ((Workflow_TypedDataContext17)(cachedCompiledDataContext[18]));
                return refDataContext92.GetLocation<string>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext17_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Workflow_TypedDataContext17_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext17_ForReadOnly valDataContext93 = ((Workflow_TypedDataContext17_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext17.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new Workflow_TypedDataContext17(locations, activityContext, true);
                }
                Workflow_TypedDataContext17 refDataContext94 = ((Workflow_TypedDataContext17)(cachedCompiledDataContext[18]));
                return refDataContext94.GetLocation<string>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext17_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Workflow_TypedDataContext17_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext17_ForReadOnly valDataContext95 = ((Workflow_TypedDataContext17_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new Workflow_TypedDataContext16_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext16_ForReadOnly valDataContext96 = ((Workflow_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new Workflow_TypedDataContext16_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext16_ForReadOnly valDataContext97 = ((Workflow_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Workflow_TypedDataContext18_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext18_ForReadOnly valDataContext98 = ((Workflow_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Workflow_TypedDataContext18_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext18_ForReadOnly valDataContext99 = ((Workflow_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext18.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new Workflow_TypedDataContext18(locations, activityContext, true);
                }
                Workflow_TypedDataContext18 refDataContext100 = ((Workflow_TypedDataContext18)(cachedCompiledDataContext[21]));
                return refDataContext100.GetLocation<string>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext19_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new Workflow_TypedDataContext19_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext19_ForReadOnly valDataContext101 = ((Workflow_TypedDataContext19_ForReadOnly)(cachedCompiledDataContext[22]));
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new Workflow_TypedDataContext20_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext20_ForReadOnly valDataContext102 = ((Workflow_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[23]));
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new Workflow_TypedDataContext20_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext20_ForReadOnly valDataContext103 = ((Workflow_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[23]));
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new Workflow_TypedDataContext20_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext20_ForReadOnly valDataContext104 = ((Workflow_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[23]));
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new Workflow_TypedDataContext21_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext21_ForReadOnly valDataContext105 = ((Workflow_TypedDataContext21_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new Workflow_TypedDataContext21(locations, activityContext, true);
                }
                Workflow_TypedDataContext21 refDataContext106 = ((Workflow_TypedDataContext21)(cachedCompiledDataContext[25]));
                return refDataContext106.GetLocation<string>(refDataContext106.ValueType___Expr106Get, refDataContext106.ValueType___Expr106Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new Workflow_TypedDataContext21_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext21_ForReadOnly valDataContext107 = ((Workflow_TypedDataContext21_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new Workflow_TypedDataContext21(locations, activityContext, true);
                }
                Workflow_TypedDataContext21 refDataContext108 = ((Workflow_TypedDataContext21)(cachedCompiledDataContext[25]));
                return refDataContext108.GetLocation<string>(refDataContext108.ValueType___Expr108Get, refDataContext108.ValueType___Expr108Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new Workflow_TypedDataContext21(locations, activityContext, true);
                }
                Workflow_TypedDataContext21 refDataContext109 = ((Workflow_TypedDataContext21)(cachedCompiledDataContext[25]));
                return refDataContext109.GetLocation<string>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new Workflow_TypedDataContext21(locations, activityContext, true);
                }
                Workflow_TypedDataContext21 refDataContext110 = ((Workflow_TypedDataContext21)(cachedCompiledDataContext[25]));
                return refDataContext110.GetLocation<string>(refDataContext110.ValueType___Expr110Get, refDataContext110.ValueType___Expr110Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new Workflow_TypedDataContext21_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext21_ForReadOnly valDataContext111 = ((Workflow_TypedDataContext21_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext111.ValueType___Expr111Get();
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new Workflow_TypedDataContext21(locations, activityContext, true);
                }
                Workflow_TypedDataContext21 refDataContext112 = ((Workflow_TypedDataContext21)(cachedCompiledDataContext[25]));
                return refDataContext112.GetLocation<string>(refDataContext112.ValueType___Expr112Get, refDataContext112.ValueType___Expr112Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new Workflow_TypedDataContext21_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext21_ForReadOnly valDataContext113 = ((Workflow_TypedDataContext21_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new Workflow_TypedDataContext21(locations, activityContext, true);
                }
                Workflow_TypedDataContext21 refDataContext114 = ((Workflow_TypedDataContext21)(cachedCompiledDataContext[25]));
                return refDataContext114.GetLocation<string>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[26] == null)) {
                    cachedCompiledDataContext[26] = new Workflow_TypedDataContext22_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext22_ForReadOnly valDataContext115 = ((Workflow_TypedDataContext22_ForReadOnly)(cachedCompiledDataContext[26]));
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[27] == null)) {
                    cachedCompiledDataContext[27] = new Workflow_TypedDataContext22(locations, activityContext, true);
                }
                Workflow_TypedDataContext22 refDataContext116 = ((Workflow_TypedDataContext22)(cachedCompiledDataContext[27]));
                return refDataContext116.GetLocation<string>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 117)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[26] == null)) {
                    cachedCompiledDataContext[26] = new Workflow_TypedDataContext22_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext22_ForReadOnly valDataContext117 = ((Workflow_TypedDataContext22_ForReadOnly)(cachedCompiledDataContext[26]));
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[27] == null)) {
                    cachedCompiledDataContext[27] = new Workflow_TypedDataContext22(locations, activityContext, true);
                }
                Workflow_TypedDataContext22 refDataContext118 = ((Workflow_TypedDataContext22)(cachedCompiledDataContext[27]));
                return refDataContext118.GetLocation<string>(refDataContext118.ValueType___Expr118Get, refDataContext118.ValueType___Expr118Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 119)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[27] == null)) {
                    cachedCompiledDataContext[27] = new Workflow_TypedDataContext22(locations, activityContext, true);
                }
                Workflow_TypedDataContext22 refDataContext119 = ((Workflow_TypedDataContext22)(cachedCompiledDataContext[27]));
                return refDataContext119.GetLocation<string>(refDataContext119.ValueType___Expr119Get, refDataContext119.ValueType___Expr119Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 120)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[27] == null)) {
                    cachedCompiledDataContext[27] = new Workflow_TypedDataContext22(locations, activityContext, true);
                }
                Workflow_TypedDataContext22 refDataContext120 = ((Workflow_TypedDataContext22)(cachedCompiledDataContext[27]));
                return refDataContext120.GetLocation<string>(refDataContext120.ValueType___Expr120Get, refDataContext120.ValueType___Expr120Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 121)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[26] == null)) {
                    cachedCompiledDataContext[26] = new Workflow_TypedDataContext22_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext22_ForReadOnly valDataContext121 = ((Workflow_TypedDataContext22_ForReadOnly)(cachedCompiledDataContext[26]));
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[27] == null)) {
                    cachedCompiledDataContext[27] = new Workflow_TypedDataContext22(locations, activityContext, true);
                }
                Workflow_TypedDataContext22 refDataContext122 = ((Workflow_TypedDataContext22)(cachedCompiledDataContext[27]));
                return refDataContext122.GetLocation<string>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 123)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[26] == null)) {
                    cachedCompiledDataContext[26] = new Workflow_TypedDataContext22_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext22_ForReadOnly valDataContext123 = ((Workflow_TypedDataContext22_ForReadOnly)(cachedCompiledDataContext[26]));
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[27] == null)) {
                    cachedCompiledDataContext[27] = new Workflow_TypedDataContext22(locations, activityContext, true);
                }
                Workflow_TypedDataContext22 refDataContext124 = ((Workflow_TypedDataContext22)(cachedCompiledDataContext[27]));
                return refDataContext124.GetLocation<string>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 125)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[28] == null)) {
                    cachedCompiledDataContext[28] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext125 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[28]));
                return valDataContext125.ValueType___Expr125Get();
            }
            if ((expressionId == 126)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[28] == null)) {
                    cachedCompiledDataContext[28] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext126 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[28]));
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[28] == null)) {
                    cachedCompiledDataContext[28] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext127 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[28]));
                return valDataContext127.ValueType___Expr127Get();
            }
            if ((expressionId == 128)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[28] == null)) {
                    cachedCompiledDataContext[28] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext128 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[28]));
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[28] == null)) {
                    cachedCompiledDataContext[28] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext129 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[28]));
                return valDataContext129.ValueType___Expr129Get();
            }
            if ((expressionId == 130)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext24_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext24_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext24_ForReadOnly valDataContext130 = ((Workflow_TypedDataContext24_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext24_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext24_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext24_ForReadOnly valDataContext131 = ((Workflow_TypedDataContext24_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext24_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext24_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext24_ForReadOnly valDataContext132 = ((Workflow_TypedDataContext24_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext132.ValueType___Expr132Get();
            }
            if ((expressionId == 133)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext24_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext24_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext24_ForReadOnly valDataContext133 = ((Workflow_TypedDataContext24_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext133.ValueType___Expr133Get();
            }
            if ((expressionId == 134)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext24_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext24_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext24_ForReadOnly valDataContext134 = ((Workflow_TypedDataContext24_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext25.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[30] == null)) {
                    cachedCompiledDataContext[30] = new Workflow_TypedDataContext25(locations, activityContext, true);
                }
                Workflow_TypedDataContext25 refDataContext135 = ((Workflow_TypedDataContext25)(cachedCompiledDataContext[30]));
                return refDataContext135.GetLocation<string>(refDataContext135.ValueType___Expr135Get, refDataContext135.ValueType___Expr135Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 136)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext25_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[31] == null)) {
                    cachedCompiledDataContext[31] = new Workflow_TypedDataContext25_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext25_ForReadOnly valDataContext136 = ((Workflow_TypedDataContext25_ForReadOnly)(cachedCompiledDataContext[31]));
                return valDataContext136.ValueType___Expr136Get();
            }
            if ((expressionId == 137)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext25_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[31] == null)) {
                    cachedCompiledDataContext[31] = new Workflow_TypedDataContext25_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext25_ForReadOnly valDataContext137 = ((Workflow_TypedDataContext25_ForReadOnly)(cachedCompiledDataContext[31]));
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext25_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[31] == null)) {
                    cachedCompiledDataContext[31] = new Workflow_TypedDataContext25_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext25_ForReadOnly valDataContext138 = ((Workflow_TypedDataContext25_ForReadOnly)(cachedCompiledDataContext[31]));
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext25_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[31] == null)) {
                    cachedCompiledDataContext[31] = new Workflow_TypedDataContext25_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext25_ForReadOnly valDataContext139 = ((Workflow_TypedDataContext25_ForReadOnly)(cachedCompiledDataContext[31]));
                return valDataContext139.ValueType___Expr139Get();
            }
            if ((expressionId == 140)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext25_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[31] == null)) {
                    cachedCompiledDataContext[31] = new Workflow_TypedDataContext25_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext25_ForReadOnly valDataContext140 = ((Workflow_TypedDataContext25_ForReadOnly)(cachedCompiledDataContext[31]));
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext25_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[31] == null)) {
                    cachedCompiledDataContext[31] = new Workflow_TypedDataContext25_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext25_ForReadOnly valDataContext141 = ((Workflow_TypedDataContext25_ForReadOnly)(cachedCompiledDataContext[31]));
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext25_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[31] == null)) {
                    cachedCompiledDataContext[31] = new Workflow_TypedDataContext25_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext25_ForReadOnly valDataContext142 = ((Workflow_TypedDataContext25_ForReadOnly)(cachedCompiledDataContext[31]));
                return valDataContext142.ValueType___Expr142Get();
            }
            if ((expressionId == 143)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext25_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 32);
                if ((cachedCompiledDataContext[31] == null)) {
                    cachedCompiledDataContext[31] = new Workflow_TypedDataContext25_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext25_ForReadOnly valDataContext143 = ((Workflow_TypedDataContext25_ForReadOnly)(cachedCompiledDataContext[31]));
                return valDataContext143.ValueType___Expr143Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                Workflow_TypedDataContext4 refDataContext0 = new Workflow_TypedDataContext4(locations, true);
                return refDataContext0.GetLocation<string>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set);
            }
            if ((expressionId == 1)) {
                Workflow_TypedDataContext4 refDataContext1 = new Workflow_TypedDataContext4(locations, true);
                return refDataContext1.GetLocation<int>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                Workflow_TypedDataContext4 refDataContext2 = new Workflow_TypedDataContext4(locations, true);
                return refDataContext2.GetLocation<string>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                Workflow_TypedDataContext4 refDataContext3 = new Workflow_TypedDataContext4(locations, true);
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                Workflow_TypedDataContext4_ForReadOnly valDataContext4 = new Workflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                Workflow_TypedDataContext4 refDataContext5 = new Workflow_TypedDataContext4(locations, true);
                return refDataContext5.GetLocation<System.Guid>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                Workflow_TypedDataContext4_ForReadOnly valDataContext6 = new Workflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                Workflow_TypedDataContext6 refDataContext7 = new Workflow_TypedDataContext6(locations, true);
                return refDataContext7.GetLocation<int>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                Workflow_TypedDataContext6 refDataContext8 = new Workflow_TypedDataContext6(locations, true);
                return refDataContext8.GetLocation<bool>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                Workflow_TypedDataContext7_ForReadOnly valDataContext9 = new Workflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                Workflow_TypedDataContext7_ForReadOnly valDataContext10 = new Workflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                Workflow_TypedDataContext7 refDataContext11 = new Workflow_TypedDataContext7(locations, true);
                return refDataContext11.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                Workflow_TypedDataContext7_ForReadOnly valDataContext12 = new Workflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext13 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext14 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext15 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext16 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext17 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                Workflow_TypedDataContext8 refDataContext18 = new Workflow_TypedDataContext8(locations, true);
                return refDataContext18.GetLocation<int>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext19 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext20 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext21 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext22 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext23 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext24 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext25 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                Workflow_TypedDataContext8 refDataContext26 = new Workflow_TypedDataContext8(locations, true);
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                Workflow_TypedDataContext8 refDataContext27 = new Workflow_TypedDataContext8(locations, true);
                return refDataContext27.GetLocation<string>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                Workflow_TypedDataContext8 refDataContext28 = new Workflow_TypedDataContext8(locations, true);
                return refDataContext28.GetLocation<string>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                Workflow_TypedDataContext8 refDataContext29 = new Workflow_TypedDataContext8(locations, true);
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                Workflow_TypedDataContext8 refDataContext30 = new Workflow_TypedDataContext8(locations, true);
                return refDataContext30.GetLocation<string>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                Workflow_TypedDataContext7_ForReadOnly valDataContext31 = new Workflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                Workflow_TypedDataContext7 refDataContext32 = new Workflow_TypedDataContext7(locations, true);
                return refDataContext32.GetLocation<string>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                Workflow_TypedDataContext7 refDataContext33 = new Workflow_TypedDataContext7(locations, true);
                return refDataContext33.GetLocation<string>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                Workflow_TypedDataContext7 refDataContext34 = new Workflow_TypedDataContext7(locations, true);
                return refDataContext34.GetLocation<string>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                Workflow_TypedDataContext7 refDataContext35 = new Workflow_TypedDataContext7(locations, true);
                return refDataContext35.GetLocation<string>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                Workflow_TypedDataContext7_ForReadOnly valDataContext36 = new Workflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                Workflow_TypedDataContext7_ForReadOnly valDataContext37 = new Workflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                Workflow_TypedDataContext7_ForReadOnly valDataContext38 = new Workflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                Workflow_TypedDataContext7 refDataContext39 = new Workflow_TypedDataContext7(locations, true);
                return refDataContext39.GetLocation<bool>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                Workflow_TypedDataContext9_ForReadOnly valDataContext40 = new Workflow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                Workflow_TypedDataContext9 refDataContext41 = new Workflow_TypedDataContext9(locations, true);
                return refDataContext41.GetLocation<int>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set);
            }
            if ((expressionId == 42)) {
                Workflow_TypedDataContext9 refDataContext42 = new Workflow_TypedDataContext9(locations, true);
                return refDataContext42.GetLocation<int>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                Workflow_TypedDataContext9_ForReadOnly valDataContext43 = new Workflow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                Workflow_TypedDataContext9 refDataContext44 = new Workflow_TypedDataContext9(locations, true);
                return refDataContext44.GetLocation<int>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
            }
            if ((expressionId == 45)) {
                Workflow_TypedDataContext9_ForReadOnly valDataContext45 = new Workflow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                Workflow_TypedDataContext9_ForReadOnly valDataContext46 = new Workflow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                Workflow_TypedDataContext9_ForReadOnly valDataContext47 = new Workflow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                Workflow_TypedDataContext9_ForReadOnly valDataContext48 = new Workflow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                Workflow_TypedDataContext9 refDataContext49 = new Workflow_TypedDataContext9(locations, true);
                return refDataContext49.GetLocation<int>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set);
            }
            if ((expressionId == 50)) {
                Workflow_TypedDataContext9_ForReadOnly valDataContext50 = new Workflow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                Workflow_TypedDataContext6 refDataContext51 = new Workflow_TypedDataContext6(locations, true);
                return refDataContext51.GetLocation<int>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                Workflow_TypedDataContext6 refDataContext52 = new Workflow_TypedDataContext6(locations, true);
                return refDataContext52.GetLocation<bool>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set);
            }
            if ((expressionId == 53)) {
                Workflow_TypedDataContext6_ForReadOnly valDataContext53 = new Workflow_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                Workflow_TypedDataContext6_ForReadOnly valDataContext54 = new Workflow_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                Workflow_TypedDataContext6_ForReadOnly valDataContext55 = new Workflow_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                Workflow_TypedDataContext6_ForReadOnly valDataContext56 = new Workflow_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                Workflow_TypedDataContext12_ForReadOnly valDataContext57 = new Workflow_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                Workflow_TypedDataContext12 refDataContext58 = new Workflow_TypedDataContext12(locations, true);
                return refDataContext58.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set);
            }
            if ((expressionId == 59)) {
                Workflow_TypedDataContext12_ForReadOnly valDataContext59 = new Workflow_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                Workflow_TypedDataContext12 refDataContext60 = new Workflow_TypedDataContext12(locations, true);
                return refDataContext60.GetLocation<string>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set);
            }
            if ((expressionId == 61)) {
                Workflow_TypedDataContext12 refDataContext61 = new Workflow_TypedDataContext12(locations, true);
                return refDataContext61.GetLocation<string>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                Workflow_TypedDataContext12 refDataContext62 = new Workflow_TypedDataContext12(locations, true);
                return refDataContext62.GetLocation<double>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set);
            }
            if ((expressionId == 63)) {
                Workflow_TypedDataContext12_ForReadOnly valDataContext63 = new Workflow_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                Workflow_TypedDataContext12 refDataContext64 = new Workflow_TypedDataContext12(locations, true);
                return refDataContext64.GetLocation<string>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set);
            }
            if ((expressionId == 65)) {
                Workflow_TypedDataContext12 refDataContext65 = new Workflow_TypedDataContext12(locations, true);
                return refDataContext65.GetLocation<string>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set);
            }
            if ((expressionId == 66)) {
                Workflow_TypedDataContext12 refDataContext66 = new Workflow_TypedDataContext12(locations, true);
                return refDataContext66.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set);
            }
            if ((expressionId == 67)) {
                Workflow_TypedDataContext12 refDataContext67 = new Workflow_TypedDataContext12(locations, true);
                return refDataContext67.GetLocation<string>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set);
            }
            if ((expressionId == 68)) {
                Workflow_TypedDataContext12 refDataContext68 = new Workflow_TypedDataContext12(locations, true);
                return refDataContext68.GetLocation<string>(refDataContext68.ValueType___Expr68Get, refDataContext68.ValueType___Expr68Set);
            }
            if ((expressionId == 69)) {
                Workflow_TypedDataContext12_ForReadOnly valDataContext69 = new Workflow_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                Workflow_TypedDataContext12_ForReadOnly valDataContext70 = new Workflow_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                Workflow_TypedDataContext12 refDataContext71 = new Workflow_TypedDataContext12(locations, true);
                return refDataContext71.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set);
            }
            if ((expressionId == 72)) {
                Workflow_TypedDataContext12_ForReadOnly valDataContext72 = new Workflow_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                Workflow_TypedDataContext12_ForReadOnly valDataContext73 = new Workflow_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                Workflow_TypedDataContext12_ForReadOnly valDataContext74 = new Workflow_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                Workflow_TypedDataContext13 refDataContext75 = new Workflow_TypedDataContext13(locations, true);
                return refDataContext75.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set);
            }
            if ((expressionId == 76)) {
                Workflow_TypedDataContext13_ForReadOnly valDataContext76 = new Workflow_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                Workflow_TypedDataContext13 refDataContext77 = new Workflow_TypedDataContext13(locations, true);
                return refDataContext77.GetLocation<string>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set);
            }
            if ((expressionId == 78)) {
                Workflow_TypedDataContext13_ForReadOnly valDataContext78 = new Workflow_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                Workflow_TypedDataContext13_ForReadOnly valDataContext79 = new Workflow_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext79.ValueType___Expr79Get();
            }
            if ((expressionId == 80)) {
                Workflow_TypedDataContext13_ForReadOnly valDataContext80 = new Workflow_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                Workflow_TypedDataContext13 refDataContext81 = new Workflow_TypedDataContext13(locations, true);
                return refDataContext81.GetLocation<string>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set);
            }
            if ((expressionId == 82)) {
                Workflow_TypedDataContext11_ForReadOnly valDataContext82 = new Workflow_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                Workflow_TypedDataContext11_ForReadOnly valDataContext83 = new Workflow_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                Workflow_TypedDataContext14_ForReadOnly valDataContext84 = new Workflow_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                Workflow_TypedDataContext14_ForReadOnly valDataContext85 = new Workflow_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                Workflow_TypedDataContext14 refDataContext86 = new Workflow_TypedDataContext14(locations, true);
                return refDataContext86.GetLocation<string>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set);
            }
            if ((expressionId == 87)) {
                Workflow_TypedDataContext17_ForReadOnly valDataContext87 = new Workflow_TypedDataContext17_ForReadOnly(locations, true);
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                Workflow_TypedDataContext17 refDataContext88 = new Workflow_TypedDataContext17(locations, true);
                return refDataContext88.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext88.ValueType___Expr88Get, refDataContext88.ValueType___Expr88Set);
            }
            if ((expressionId == 89)) {
                Workflow_TypedDataContext17_ForReadOnly valDataContext89 = new Workflow_TypedDataContext17_ForReadOnly(locations, true);
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                Workflow_TypedDataContext17 refDataContext90 = new Workflow_TypedDataContext17(locations, true);
                return refDataContext90.GetLocation<string>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set);
            }
            if ((expressionId == 91)) {
                Workflow_TypedDataContext17 refDataContext91 = new Workflow_TypedDataContext17(locations, true);
                return refDataContext91.GetLocation<string>(refDataContext91.ValueType___Expr91Get, refDataContext91.ValueType___Expr91Set);
            }
            if ((expressionId == 92)) {
                Workflow_TypedDataContext17 refDataContext92 = new Workflow_TypedDataContext17(locations, true);
                return refDataContext92.GetLocation<string>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set);
            }
            if ((expressionId == 93)) {
                Workflow_TypedDataContext17_ForReadOnly valDataContext93 = new Workflow_TypedDataContext17_ForReadOnly(locations, true);
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                Workflow_TypedDataContext17 refDataContext94 = new Workflow_TypedDataContext17(locations, true);
                return refDataContext94.GetLocation<string>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set);
            }
            if ((expressionId == 95)) {
                Workflow_TypedDataContext17_ForReadOnly valDataContext95 = new Workflow_TypedDataContext17_ForReadOnly(locations, true);
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                Workflow_TypedDataContext16_ForReadOnly valDataContext96 = new Workflow_TypedDataContext16_ForReadOnly(locations, true);
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                Workflow_TypedDataContext16_ForReadOnly valDataContext97 = new Workflow_TypedDataContext16_ForReadOnly(locations, true);
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                Workflow_TypedDataContext18_ForReadOnly valDataContext98 = new Workflow_TypedDataContext18_ForReadOnly(locations, true);
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                Workflow_TypedDataContext18_ForReadOnly valDataContext99 = new Workflow_TypedDataContext18_ForReadOnly(locations, true);
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                Workflow_TypedDataContext18 refDataContext100 = new Workflow_TypedDataContext18(locations, true);
                return refDataContext100.GetLocation<string>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set);
            }
            if ((expressionId == 101)) {
                Workflow_TypedDataContext19_ForReadOnly valDataContext101 = new Workflow_TypedDataContext19_ForReadOnly(locations, true);
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                Workflow_TypedDataContext20_ForReadOnly valDataContext102 = new Workflow_TypedDataContext20_ForReadOnly(locations, true);
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                Workflow_TypedDataContext20_ForReadOnly valDataContext103 = new Workflow_TypedDataContext20_ForReadOnly(locations, true);
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                Workflow_TypedDataContext20_ForReadOnly valDataContext104 = new Workflow_TypedDataContext20_ForReadOnly(locations, true);
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                Workflow_TypedDataContext21_ForReadOnly valDataContext105 = new Workflow_TypedDataContext21_ForReadOnly(locations, true);
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                Workflow_TypedDataContext21 refDataContext106 = new Workflow_TypedDataContext21(locations, true);
                return refDataContext106.GetLocation<string>(refDataContext106.ValueType___Expr106Get, refDataContext106.ValueType___Expr106Set);
            }
            if ((expressionId == 107)) {
                Workflow_TypedDataContext21_ForReadOnly valDataContext107 = new Workflow_TypedDataContext21_ForReadOnly(locations, true);
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                Workflow_TypedDataContext21 refDataContext108 = new Workflow_TypedDataContext21(locations, true);
                return refDataContext108.GetLocation<string>(refDataContext108.ValueType___Expr108Get, refDataContext108.ValueType___Expr108Set);
            }
            if ((expressionId == 109)) {
                Workflow_TypedDataContext21 refDataContext109 = new Workflow_TypedDataContext21(locations, true);
                return refDataContext109.GetLocation<string>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set);
            }
            if ((expressionId == 110)) {
                Workflow_TypedDataContext21 refDataContext110 = new Workflow_TypedDataContext21(locations, true);
                return refDataContext110.GetLocation<string>(refDataContext110.ValueType___Expr110Get, refDataContext110.ValueType___Expr110Set);
            }
            if ((expressionId == 111)) {
                Workflow_TypedDataContext21_ForReadOnly valDataContext111 = new Workflow_TypedDataContext21_ForReadOnly(locations, true);
                return valDataContext111.ValueType___Expr111Get();
            }
            if ((expressionId == 112)) {
                Workflow_TypedDataContext21 refDataContext112 = new Workflow_TypedDataContext21(locations, true);
                return refDataContext112.GetLocation<string>(refDataContext112.ValueType___Expr112Get, refDataContext112.ValueType___Expr112Set);
            }
            if ((expressionId == 113)) {
                Workflow_TypedDataContext21_ForReadOnly valDataContext113 = new Workflow_TypedDataContext21_ForReadOnly(locations, true);
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                Workflow_TypedDataContext21 refDataContext114 = new Workflow_TypedDataContext21(locations, true);
                return refDataContext114.GetLocation<string>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set);
            }
            if ((expressionId == 115)) {
                Workflow_TypedDataContext22_ForReadOnly valDataContext115 = new Workflow_TypedDataContext22_ForReadOnly(locations, true);
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                Workflow_TypedDataContext22 refDataContext116 = new Workflow_TypedDataContext22(locations, true);
                return refDataContext116.GetLocation<string>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set);
            }
            if ((expressionId == 117)) {
                Workflow_TypedDataContext22_ForReadOnly valDataContext117 = new Workflow_TypedDataContext22_ForReadOnly(locations, true);
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                Workflow_TypedDataContext22 refDataContext118 = new Workflow_TypedDataContext22(locations, true);
                return refDataContext118.GetLocation<string>(refDataContext118.ValueType___Expr118Get, refDataContext118.ValueType___Expr118Set);
            }
            if ((expressionId == 119)) {
                Workflow_TypedDataContext22 refDataContext119 = new Workflow_TypedDataContext22(locations, true);
                return refDataContext119.GetLocation<string>(refDataContext119.ValueType___Expr119Get, refDataContext119.ValueType___Expr119Set);
            }
            if ((expressionId == 120)) {
                Workflow_TypedDataContext22 refDataContext120 = new Workflow_TypedDataContext22(locations, true);
                return refDataContext120.GetLocation<string>(refDataContext120.ValueType___Expr120Get, refDataContext120.ValueType___Expr120Set);
            }
            if ((expressionId == 121)) {
                Workflow_TypedDataContext22_ForReadOnly valDataContext121 = new Workflow_TypedDataContext22_ForReadOnly(locations, true);
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                Workflow_TypedDataContext22 refDataContext122 = new Workflow_TypedDataContext22(locations, true);
                return refDataContext122.GetLocation<string>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set);
            }
            if ((expressionId == 123)) {
                Workflow_TypedDataContext22_ForReadOnly valDataContext123 = new Workflow_TypedDataContext22_ForReadOnly(locations, true);
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                Workflow_TypedDataContext22 refDataContext124 = new Workflow_TypedDataContext22(locations, true);
                return refDataContext124.GetLocation<string>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set);
            }
            if ((expressionId == 125)) {
                Workflow_TypedDataContext23_ForReadOnly valDataContext125 = new Workflow_TypedDataContext23_ForReadOnly(locations, true);
                return valDataContext125.ValueType___Expr125Get();
            }
            if ((expressionId == 126)) {
                Workflow_TypedDataContext23_ForReadOnly valDataContext126 = new Workflow_TypedDataContext23_ForReadOnly(locations, true);
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                Workflow_TypedDataContext23_ForReadOnly valDataContext127 = new Workflow_TypedDataContext23_ForReadOnly(locations, true);
                return valDataContext127.ValueType___Expr127Get();
            }
            if ((expressionId == 128)) {
                Workflow_TypedDataContext23_ForReadOnly valDataContext128 = new Workflow_TypedDataContext23_ForReadOnly(locations, true);
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                Workflow_TypedDataContext23_ForReadOnly valDataContext129 = new Workflow_TypedDataContext23_ForReadOnly(locations, true);
                return valDataContext129.ValueType___Expr129Get();
            }
            if ((expressionId == 130)) {
                Workflow_TypedDataContext24_ForReadOnly valDataContext130 = new Workflow_TypedDataContext24_ForReadOnly(locations, true);
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                Workflow_TypedDataContext24_ForReadOnly valDataContext131 = new Workflow_TypedDataContext24_ForReadOnly(locations, true);
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                Workflow_TypedDataContext24_ForReadOnly valDataContext132 = new Workflow_TypedDataContext24_ForReadOnly(locations, true);
                return valDataContext132.ValueType___Expr132Get();
            }
            if ((expressionId == 133)) {
                Workflow_TypedDataContext24_ForReadOnly valDataContext133 = new Workflow_TypedDataContext24_ForReadOnly(locations, true);
                return valDataContext133.ValueType___Expr133Get();
            }
            if ((expressionId == 134)) {
                Workflow_TypedDataContext24_ForReadOnly valDataContext134 = new Workflow_TypedDataContext24_ForReadOnly(locations, true);
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                Workflow_TypedDataContext25 refDataContext135 = new Workflow_TypedDataContext25(locations, true);
                return refDataContext135.GetLocation<string>(refDataContext135.ValueType___Expr135Get, refDataContext135.ValueType___Expr135Set);
            }
            if ((expressionId == 136)) {
                Workflow_TypedDataContext25_ForReadOnly valDataContext136 = new Workflow_TypedDataContext25_ForReadOnly(locations, true);
                return valDataContext136.ValueType___Expr136Get();
            }
            if ((expressionId == 137)) {
                Workflow_TypedDataContext25_ForReadOnly valDataContext137 = new Workflow_TypedDataContext25_ForReadOnly(locations, true);
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                Workflow_TypedDataContext25_ForReadOnly valDataContext138 = new Workflow_TypedDataContext25_ForReadOnly(locations, true);
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                Workflow_TypedDataContext25_ForReadOnly valDataContext139 = new Workflow_TypedDataContext25_ForReadOnly(locations, true);
                return valDataContext139.ValueType___Expr139Get();
            }
            if ((expressionId == 140)) {
                Workflow_TypedDataContext25_ForReadOnly valDataContext140 = new Workflow_TypedDataContext25_ForReadOnly(locations, true);
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                Workflow_TypedDataContext25_ForReadOnly valDataContext141 = new Workflow_TypedDataContext25_ForReadOnly(locations, true);
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                Workflow_TypedDataContext25_ForReadOnly valDataContext142 = new Workflow_TypedDataContext25_ForReadOnly(locations, true);
                return valDataContext142.ValueType___Expr142Get();
            }
            if ((expressionId == 143)) {
                Workflow_TypedDataContext25_ForReadOnly valDataContext143 = new Workflow_TypedDataContext25_ForReadOnly(locations, true);
                return valDataContext143.ValueType___Expr143Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == true) 
                        && ((expressionText == "CurrentSiteUrl") 
                        && (Workflow_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentListID") 
                        && (Workflow_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentListName") 
                        && (Workflow_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Guid(CurrentListID)") 
                        && (Workflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"List : \"+CurrentListID+\"\\r\\n\"+\n\"ItemID : \"+CurrentItemID") 
                        && (Workflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iscancelstate") 
                        && (Workflow_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iscompleteParallel") 
                        && (Workflow_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"--Manager ID in Send Task : \"+OfficerManager+\n\"--HR ID in Send Task : \" + listHr" +
                            "Approve.Count +\n\"--Title in Send Task : \" + Title + \n\"--LeaveStatus in Send Task" +
                            " : \" + LeaveStatus + \n\"--LeaveType in Send Task : \" + LeaveType") 
                        && (Workflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequesterId") 
                        && (Workflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EmailToRequester") 
                        && (Workflow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!string.IsNullOrEmpty(OfficerManager)") 
                        && (Workflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TitleManagerEmail") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BodyManagerEmail") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"""<table style='font-family:Angsana New;font-size:26px;'><tr><td>"" +
  BodyManagerEmail + ""  "" + ""<a href='"" + CurrentUrl + ""?SPHostUrl="" + CurrentHostUrl + ""&SPAppWebUrl="" + CurrentAppUrl + ""&CaseView=0&CurItemId="" + CurrentItemID + ""&TaskUrl=%TaskSpecial: TaskUrl%'>รายละเอียด</a>""+
""</td></tr></table>""") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"<table style=\'font-family:Angsana New;font-size:26px;\'><tr><td>\" +\n             " +
                            "   \"เนื่องจากผู้ขออนุมัติได้ยกเลิกการขออนุมัติการลา จึงแจ้งมาเพื่อทราบ\"+\n\"</td><" +
                            "/tr></table>\"") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BodyManagerEmail") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "outcome_0") 
                        && (Workflow_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TitleManagerEmail") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "OfficerManager") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TitleManagerEmail") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"แจ้งยกเลิกการขออนุมัติการลาของ \" + Title") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Output :\" + outcome_0.ToString()") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "outcome_0 == 0") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"new\") || RequestType.ToLower().Equals(\"1\")") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ApproveStatus") 
                        && (Workflow_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ApproveStatus") 
                        && (Workflow_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"new\")") 
                        && (Workflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ApproveStatus") 
                        && (Workflow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ExtraOwnApprove") 
                        && (Workflow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EmailToRequester") 
                        && (Workflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"""<table style='font-family:Angsana New;font-size:26px;'><tr><td>"" +
                BodyRequesterEmail +ApproveStatus+ "" การขออนุมัติของท่าน "" + ""<a href='"" + CurrentUrl + ""?SPHostUrl="" + CurrentHostUrl + ""&SPAppWebUrl="" + CurrentAppUrl + ""&CaseView=1&CurItemId="" + CurrentItemID + ""'>รายละเอียด</a>""+
""</td></tr></table>""") 
                        && (Workflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TitleRequesterEmail+ExtraOwnApprove") 
                        && (Workflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iscompleteParallel") 
                        && (Workflow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Error In Send Task :\"+exception.ToString().Length") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "errorindex") 
                        && (Workflow_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "errormax") 
                        && (Workflow_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "exception.ToString().Length") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "errorlen") 
                        && (Workflow_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(errorlen-errorindex) > errormax") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "exception.ToString().Substring(errorindex,errormax)") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "exception.ToString().Substring(errorindex,(errorlen-errorindex))") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "errorindex+errormax") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "errorindex") 
                        && (Workflow_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "errorindex < exception.ToString().Length;") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iscancelstate") 
                        && (Workflow_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iscompleteParallel") 
                        && (Workflow_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iscompleteParallel") 
                        && (Workflow_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(RequestType.ToLower().Equals(\"new\") || RequestType.ToLower().Equals(\"1\")) && isc" +
                            "ancelstate == 0") 
                        && (Workflow_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(RequestType.ToLower().Equals(\"cancel\") || RequestType.ToLower().Equals(\"2\") )&& " +
                            "iscancelstate == 0") 
                        && (Workflow_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iscancelstate == 1") 
                        && (Workflow_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "listItemProps") 
                        && (Workflow_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeaveStatus") 
                        && (Workflow_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RequesterId") 
                        && (Workflow_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NumberOfDay") 
                        && (Workflow_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "listItemProps") 
                        && (Workflow_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeaveType") 
                        && (Workflow_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Title") 
                        && (Workflow_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dynamichr") 
                        && (Workflow_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeaveDictionaryText") 
                        && (Workflow_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "OfficerManager") 
                        && (Workflow_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dynamichr != null") 
                        && (Workflow_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dynamichr") 
                        && (Workflow_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "listHrApprove") 
                        && (Workflow_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dynamichr.ToString()") 
                        && (Workflow_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"RequesterId ID in Get Info : \" + RequesterId +\n\"\\r\\nManager ID in Get Info : \" +" +
                            "OfficerManager+\n\"\\r\\nHR ID in Get Info : \" + listHrApprove.Count") 
                        && (Workflow_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!string.IsNullOrEmpty(LeaveDictionaryText)") 
                        && (Workflow_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeaveDictionary") 
                        && (Workflow_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "LeaveDictionaryText") 
                        && (Workflow_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeaveTextTitle") 
                        && (Workflow_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "LeaveDictionary") 
                        && (Workflow_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "LeaveType") 
                        && (Workflow_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "LeaveTextTitle") 
                        && (Workflow_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeaveType") 
                        && (Workflow_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"new\") || RequestType.ToLower().Equals(\"1\")") 
                        && (Workflow_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"cancel\") || RequestType.ToLower().Equals(\"2\")") 
                        && (Workflow_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ApproveStatus") 
                        && (Workflow_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext17_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dv_0") 
                        && (Workflow_TypedDataContext17.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext17_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentAppUrl") 
                        && (Workflow_TypedDataContext17.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RequestType") 
                        && (Workflow_TypedDataContext17.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentUrl") 
                        && (Workflow_TypedDataContext17.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dv_0") 
                        && (Workflow_TypedDataContext17_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentHostUrl") 
                        && (Workflow_TypedDataContext17.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentUrl+\"\\r\\n\"+\nCurrentHostUrl + \"\\r\\n\"+\nCurrentAppUrl + \"\\r\\n\"") 
                        && (Workflow_TypedDataContext17_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"new\") || RequestType.ToLower().Equals(\"1\")") 
                        && (Workflow_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"cancel\")|| RequestType.ToLower().Equals(\"2\")") 
                        && (Workflow_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ApproveStatus") 
                        && (Workflow_TypedDataContext18.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "listHrApprove.Count > 0 && ApproveStatus.Equals(\"Approved\")") 
                        && (Workflow_TypedDataContext19_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "listHrApprove") 
                        && (Workflow_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"""<table style='font-family:Angsana New;font-size:26px;'><tr><td>"" +
                BodyHrEmail + ApproveStatus + ""  "" + ""<a href='"" + CurrentUrl + ""?SPHostUrl="" + CurrentHostUrl + ""&SPAppWebUrl="" + CurrentAppUrl + ""&CaseView=2&CurItemId="" + CurrentItemID + ""'>รายละเอียด</a>""+
""</td></tr></table>""") 
                        && (Workflow_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TitleHREmail") 
                        && (Workflow_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"แจ้งการขออนุมัติการลาของ \" + Title") 
                        && (Workflow_TypedDataContext21_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TitleManagerEmail") 
                        && (Workflow_TypedDataContext21.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"กรุณาพิจารณา การลา \" + LeaveType + \" ของ \" +Title") 
                        && (Workflow_TypedDataContext21_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BodyManagerEmail") 
                        && (Workflow_TypedDataContext21.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TitleRequesterEmail") 
                        && (Workflow_TypedDataContext21.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BodyRequesterEmail") 
                        && (Workflow_TypedDataContext21.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Review : แจ้งผลการขออนุมัติการลาของ \"+Title") 
                        && (Workflow_TypedDataContext21_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TitleHREmail") 
                        && (Workflow_TypedDataContext21.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"ตามที่ \"+ Title + \"ได้ขออนุมัติการลา \"+LeaveType+\" โดยมีผลการพิจารณา คือ \"") 
                        && (Workflow_TypedDataContext21_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BodyHrEmail") 
                        && (Workflow_TypedDataContext21.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"แจ้งการขออนุมัติยกเลิกการลาของ \" + Title") 
                        && (Workflow_TypedDataContext22_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TitleManagerEmail") 
                        && (Workflow_TypedDataContext22.Validate(locations, true, 0) == true)))) {
                expressionId = 116;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"กรุณาพิจารณา ยกเลิกการลา \" + LeaveType + \" ของ \" + Title") 
                        && (Workflow_TypedDataContext22_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 117;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BodyManagerEmail") 
                        && (Workflow_TypedDataContext22.Validate(locations, true, 0) == true)))) {
                expressionId = 118;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TitleRequesterEmail") 
                        && (Workflow_TypedDataContext22.Validate(locations, true, 0) == true)))) {
                expressionId = 119;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BodyRequesterEmail") 
                        && (Workflow_TypedDataContext22.Validate(locations, true, 0) == true)))) {
                expressionId = 120;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Review : แจ้งผลการขออนุมัติยกเลิกการลาของ \" + Title") 
                        && (Workflow_TypedDataContext22_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 121;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TitleHREmail") 
                        && (Workflow_TypedDataContext22.Validate(locations, true, 0) == true)))) {
                expressionId = 122;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"ตามที่ \" + Title + \"ได้ขออนุมัติยกเลิกการลา \" + LeaveType + \" โดยมีผลการพิจารณา " +
                            "คือ \"") 
                        && (Workflow_TypedDataContext22_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 123;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BodyHrEmail") 
                        && (Workflow_TypedDataContext22.Validate(locations, true, 0) == true)))) {
                expressionId = 124;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Set Status to : \"+setStatusRequest") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 125;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 126;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 127;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 128;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 129;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Set Status to : \"+setStatusRequest") 
                        && (Workflow_TypedDataContext24_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 130;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext24_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 131;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext24_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 132;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext24_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 133;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext24_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 134;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext25.Validate(locations, true, 0) == true)))) {
                expressionId = 135;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Set Status to : \"+setStatusRequest") 
                        && (Workflow_TypedDataContext25_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 136;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"new\")") 
                        && (Workflow_TypedDataContext25_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 137;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext25_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 138;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext25_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 139;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext25_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 140;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext25_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 141;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext25_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 142;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext25_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 143;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new Workflow_TypedDataContext4(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Workflow_TypedDataContext4(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Workflow_TypedDataContext4(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Workflow_TypedDataContext4(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Workflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Workflow_TypedDataContext4(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Workflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Workflow_TypedDataContext6(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Workflow_TypedDataContext6(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Workflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Workflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Workflow_TypedDataContext7(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Workflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Workflow_TypedDataContext8(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new Workflow_TypedDataContext8(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new Workflow_TypedDataContext8(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new Workflow_TypedDataContext8(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new Workflow_TypedDataContext8(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new Workflow_TypedDataContext8(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new Workflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new Workflow_TypedDataContext7(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new Workflow_TypedDataContext7(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new Workflow_TypedDataContext7(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new Workflow_TypedDataContext7(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new Workflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new Workflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new Workflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new Workflow_TypedDataContext7(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new Workflow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new Workflow_TypedDataContext9(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new Workflow_TypedDataContext9(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new Workflow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new Workflow_TypedDataContext9(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new Workflow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new Workflow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new Workflow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new Workflow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new Workflow_TypedDataContext9(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new Workflow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new Workflow_TypedDataContext6(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new Workflow_TypedDataContext6(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new Workflow_TypedDataContext6_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new Workflow_TypedDataContext6_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new Workflow_TypedDataContext6_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new Workflow_TypedDataContext6_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new Workflow_TypedDataContext12_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new Workflow_TypedDataContext12(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new Workflow_TypedDataContext12_ForReadOnly(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new Workflow_TypedDataContext12(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new Workflow_TypedDataContext12(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new Workflow_TypedDataContext12(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new Workflow_TypedDataContext12_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new Workflow_TypedDataContext12(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new Workflow_TypedDataContext12(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new Workflow_TypedDataContext12(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new Workflow_TypedDataContext12(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new Workflow_TypedDataContext12(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new Workflow_TypedDataContext12_ForReadOnly(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new Workflow_TypedDataContext12_ForReadOnly(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new Workflow_TypedDataContext12(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new Workflow_TypedDataContext12_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new Workflow_TypedDataContext12_ForReadOnly(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new Workflow_TypedDataContext12_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new Workflow_TypedDataContext13(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new Workflow_TypedDataContext13_ForReadOnly(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new Workflow_TypedDataContext13(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new Workflow_TypedDataContext13_ForReadOnly(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new Workflow_TypedDataContext13_ForReadOnly(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new Workflow_TypedDataContext13_ForReadOnly(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new Workflow_TypedDataContext13(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new Workflow_TypedDataContext11_ForReadOnly(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new Workflow_TypedDataContext11_ForReadOnly(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new Workflow_TypedDataContext14_ForReadOnly(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new Workflow_TypedDataContext14_ForReadOnly(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new Workflow_TypedDataContext14(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new Workflow_TypedDataContext17_ForReadOnly(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new Workflow_TypedDataContext17(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new Workflow_TypedDataContext17_ForReadOnly(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new Workflow_TypedDataContext17(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new Workflow_TypedDataContext17(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new Workflow_TypedDataContext17(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new Workflow_TypedDataContext17_ForReadOnly(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new Workflow_TypedDataContext17(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new Workflow_TypedDataContext17_ForReadOnly(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new Workflow_TypedDataContext16_ForReadOnly(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new Workflow_TypedDataContext16_ForReadOnly(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new Workflow_TypedDataContext18_ForReadOnly(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new Workflow_TypedDataContext18_ForReadOnly(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new Workflow_TypedDataContext18(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new Workflow_TypedDataContext19_ForReadOnly(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new Workflow_TypedDataContext20_ForReadOnly(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new Workflow_TypedDataContext20_ForReadOnly(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new Workflow_TypedDataContext20_ForReadOnly(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new Workflow_TypedDataContext21_ForReadOnly(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new Workflow_TypedDataContext21(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new Workflow_TypedDataContext21_ForReadOnly(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new Workflow_TypedDataContext21(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new Workflow_TypedDataContext21(locationReferences).@__Expr109GetTree();
            }
            if ((expressionId == 110)) {
                return new Workflow_TypedDataContext21(locationReferences).@__Expr110GetTree();
            }
            if ((expressionId == 111)) {
                return new Workflow_TypedDataContext21_ForReadOnly(locationReferences).@__Expr111GetTree();
            }
            if ((expressionId == 112)) {
                return new Workflow_TypedDataContext21(locationReferences).@__Expr112GetTree();
            }
            if ((expressionId == 113)) {
                return new Workflow_TypedDataContext21_ForReadOnly(locationReferences).@__Expr113GetTree();
            }
            if ((expressionId == 114)) {
                return new Workflow_TypedDataContext21(locationReferences).@__Expr114GetTree();
            }
            if ((expressionId == 115)) {
                return new Workflow_TypedDataContext22_ForReadOnly(locationReferences).@__Expr115GetTree();
            }
            if ((expressionId == 116)) {
                return new Workflow_TypedDataContext22(locationReferences).@__Expr116GetTree();
            }
            if ((expressionId == 117)) {
                return new Workflow_TypedDataContext22_ForReadOnly(locationReferences).@__Expr117GetTree();
            }
            if ((expressionId == 118)) {
                return new Workflow_TypedDataContext22(locationReferences).@__Expr118GetTree();
            }
            if ((expressionId == 119)) {
                return new Workflow_TypedDataContext22(locationReferences).@__Expr119GetTree();
            }
            if ((expressionId == 120)) {
                return new Workflow_TypedDataContext22(locationReferences).@__Expr120GetTree();
            }
            if ((expressionId == 121)) {
                return new Workflow_TypedDataContext22_ForReadOnly(locationReferences).@__Expr121GetTree();
            }
            if ((expressionId == 122)) {
                return new Workflow_TypedDataContext22(locationReferences).@__Expr122GetTree();
            }
            if ((expressionId == 123)) {
                return new Workflow_TypedDataContext22_ForReadOnly(locationReferences).@__Expr123GetTree();
            }
            if ((expressionId == 124)) {
                return new Workflow_TypedDataContext22(locationReferences).@__Expr124GetTree();
            }
            if ((expressionId == 125)) {
                return new Workflow_TypedDataContext23_ForReadOnly(locationReferences).@__Expr125GetTree();
            }
            if ((expressionId == 126)) {
                return new Workflow_TypedDataContext23_ForReadOnly(locationReferences).@__Expr126GetTree();
            }
            if ((expressionId == 127)) {
                return new Workflow_TypedDataContext23_ForReadOnly(locationReferences).@__Expr127GetTree();
            }
            if ((expressionId == 128)) {
                return new Workflow_TypedDataContext23_ForReadOnly(locationReferences).@__Expr128GetTree();
            }
            if ((expressionId == 129)) {
                return new Workflow_TypedDataContext23_ForReadOnly(locationReferences).@__Expr129GetTree();
            }
            if ((expressionId == 130)) {
                return new Workflow_TypedDataContext24_ForReadOnly(locationReferences).@__Expr130GetTree();
            }
            if ((expressionId == 131)) {
                return new Workflow_TypedDataContext24_ForReadOnly(locationReferences).@__Expr131GetTree();
            }
            if ((expressionId == 132)) {
                return new Workflow_TypedDataContext24_ForReadOnly(locationReferences).@__Expr132GetTree();
            }
            if ((expressionId == 133)) {
                return new Workflow_TypedDataContext24_ForReadOnly(locationReferences).@__Expr133GetTree();
            }
            if ((expressionId == 134)) {
                return new Workflow_TypedDataContext24_ForReadOnly(locationReferences).@__Expr134GetTree();
            }
            if ((expressionId == 135)) {
                return new Workflow_TypedDataContext25(locationReferences).@__Expr135GetTree();
            }
            if ((expressionId == 136)) {
                return new Workflow_TypedDataContext25_ForReadOnly(locationReferences).@__Expr136GetTree();
            }
            if ((expressionId == 137)) {
                return new Workflow_TypedDataContext25_ForReadOnly(locationReferences).@__Expr137GetTree();
            }
            if ((expressionId == 138)) {
                return new Workflow_TypedDataContext25_ForReadOnly(locationReferences).@__Expr138GetTree();
            }
            if ((expressionId == 139)) {
                return new Workflow_TypedDataContext25_ForReadOnly(locationReferences).@__Expr139GetTree();
            }
            if ((expressionId == 140)) {
                return new Workflow_TypedDataContext25_ForReadOnly(locationReferences).@__Expr140GetTree();
            }
            if ((expressionId == 141)) {
                return new Workflow_TypedDataContext25_ForReadOnly(locationReferences).@__Expr141GetTree();
            }
            if ((expressionId == 142)) {
                return new Workflow_TypedDataContext25_ForReadOnly(locationReferences).@__Expr142GetTree();
            }
            if ((expressionId == 143)) {
                return new Workflow_TypedDataContext25_ForReadOnly(locationReferences).@__Expr143GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext1 : Workflow_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext1_ForReadOnly : Workflow_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext2 : Workflow_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int CurrentItemID;
            
            protected System.Guid CurrentListGUID;
            
            protected double NumberOfDay;
            
            public Workflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string CurrentListID {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string Title {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected string LeaveType {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected string LeaveStatus {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected string OfficerManager {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            protected System.Collections.ObjectModel.Collection<string> listHrApprove {
                get {
                    return ((System.Collections.ObjectModel.Collection<string>)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
                }
            }
            
            protected string CurrentSiteUrl {
                get {
                    return ((string)(this.GetVariableValue((9 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((9 + locationsOffset), value);
                }
            }
            
            protected string ApproveStatus {
                get {
                    return ((string)(this.GetVariableValue((10 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((10 + locationsOffset), value);
                }
            }
            
            protected Microsoft.Activities.DynamicValue dynamichr {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((11 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((11 + locationsOffset), value);
                }
            }
            
            protected string RequestType {
                get {
                    return ((string)(this.GetVariableValue((12 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((12 + locationsOffset), value);
                }
            }
            
            protected string CancelLeaveStatus {
                get {
                    return ((string)(this.GetVariableValue((13 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((13 + locationsOffset), value);
                }
            }
            
            protected string TitleManagerEmail {
                get {
                    return ((string)(this.GetVariableValue((14 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((14 + locationsOffset), value);
                }
            }
            
            protected string BodyManagerEmail {
                get {
                    return ((string)(this.GetVariableValue((15 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((15 + locationsOffset), value);
                }
            }
            
            protected string setStatusRequest {
                get {
                    return ((string)(this.GetVariableValue((16 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((16 + locationsOffset), value);
                }
            }
            
            protected string RequesterId {
                get {
                    return ((string)(this.GetVariableValue((17 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((17 + locationsOffset), value);
                }
            }
            
            protected string TitleRequesterEmail {
                get {
                    return ((string)(this.GetVariableValue((18 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((18 + locationsOffset), value);
                }
            }
            
            protected string BodyRequesterEmail {
                get {
                    return ((string)(this.GetVariableValue((19 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((19 + locationsOffset), value);
                }
            }
            
            protected string TitleHREmail {
                get {
                    return ((string)(this.GetVariableValue((20 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((20 + locationsOffset), value);
                }
            }
            
            protected string BodyHrEmail {
                get {
                    return ((string)(this.GetVariableValue((21 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((21 + locationsOffset), value);
                }
            }
            
            protected string CurrentAppUrl {
                get {
                    return ((string)(this.GetVariableValue((22 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((22 + locationsOffset), value);
                }
            }
            
            protected string CurrentHostUrl {
                get {
                    return ((string)(this.GetVariableValue((23 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((23 + locationsOffset), value);
                }
            }
            
            protected string CurrentUrl {
                get {
                    return ((string)(this.GetVariableValue((24 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((24 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.CurrentItemID = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.CurrentListGUID = ((System.Guid)(this.GetVariableValue((2 + locationsOffset))));
                this.NumberOfDay = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.CurrentItemID);
                this.SetVariableValue((2 + locationsOffset), this.CurrentListGUID);
                this.SetVariableValue((5 + locationsOffset), this.NumberOfDay);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                if (((locationReferences[(offset + 1)].Name != "CurrentListID") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Title") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "LeaveType") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "LeaveStatus") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "OfficerManager") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "listHrApprove") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.Collections.ObjectModel.Collection<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "CurrentSiteUrl") 
                            || (locationReferences[(offset + 9)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "ApproveStatus") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "dynamichr") 
                            || (locationReferences[(offset + 11)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "RequestType") 
                            || (locationReferences[(offset + 12)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "CancelLeaveStatus") 
                            || (locationReferences[(offset + 13)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "TitleManagerEmail") 
                            || (locationReferences[(offset + 14)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "BodyManagerEmail") 
                            || (locationReferences[(offset + 15)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "setStatusRequest") 
                            || (locationReferences[(offset + 16)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "RequesterId") 
                            || (locationReferences[(offset + 17)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "TitleRequesterEmail") 
                            || (locationReferences[(offset + 18)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "BodyRequesterEmail") 
                            || (locationReferences[(offset + 19)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "TitleHREmail") 
                            || (locationReferences[(offset + 20)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "BodyHrEmail") 
                            || (locationReferences[(offset + 21)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "CurrentAppUrl") 
                            || (locationReferences[(offset + 22)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "CurrentHostUrl") 
                            || (locationReferences[(offset + 23)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "CurrentUrl") 
                            || (locationReferences[(offset + 24)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "CurrentItemID") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "CurrentListGUID") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Guid)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "NumberOfDay") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return Workflow_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext2_ForReadOnly : Workflow_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int CurrentItemID;
            
            protected System.Guid CurrentListGUID;
            
            protected double NumberOfDay;
            
            public Workflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string CurrentListID {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string Title {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected string LeaveType {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected string LeaveStatus {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected string OfficerManager {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            protected System.Collections.ObjectModel.Collection<string> listHrApprove {
                get {
                    return ((System.Collections.ObjectModel.Collection<string>)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            protected string CurrentSiteUrl {
                get {
                    return ((string)(this.GetVariableValue((9 + locationsOffset))));
                }
            }
            
            protected string ApproveStatus {
                get {
                    return ((string)(this.GetVariableValue((10 + locationsOffset))));
                }
            }
            
            protected Microsoft.Activities.DynamicValue dynamichr {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((11 + locationsOffset))));
                }
            }
            
            protected string RequestType {
                get {
                    return ((string)(this.GetVariableValue((12 + locationsOffset))));
                }
            }
            
            protected string CancelLeaveStatus {
                get {
                    return ((string)(this.GetVariableValue((13 + locationsOffset))));
                }
            }
            
            protected string TitleManagerEmail {
                get {
                    return ((string)(this.GetVariableValue((14 + locationsOffset))));
                }
            }
            
            protected string BodyManagerEmail {
                get {
                    return ((string)(this.GetVariableValue((15 + locationsOffset))));
                }
            }
            
            protected string setStatusRequest {
                get {
                    return ((string)(this.GetVariableValue((16 + locationsOffset))));
                }
            }
            
            protected string RequesterId {
                get {
                    return ((string)(this.GetVariableValue((17 + locationsOffset))));
                }
            }
            
            protected string TitleRequesterEmail {
                get {
                    return ((string)(this.GetVariableValue((18 + locationsOffset))));
                }
            }
            
            protected string BodyRequesterEmail {
                get {
                    return ((string)(this.GetVariableValue((19 + locationsOffset))));
                }
            }
            
            protected string TitleHREmail {
                get {
                    return ((string)(this.GetVariableValue((20 + locationsOffset))));
                }
            }
            
            protected string BodyHrEmail {
                get {
                    return ((string)(this.GetVariableValue((21 + locationsOffset))));
                }
            }
            
            protected string CurrentAppUrl {
                get {
                    return ((string)(this.GetVariableValue((22 + locationsOffset))));
                }
            }
            
            protected string CurrentHostUrl {
                get {
                    return ((string)(this.GetVariableValue((23 + locationsOffset))));
                }
            }
            
            protected string CurrentUrl {
                get {
                    return ((string)(this.GetVariableValue((24 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.CurrentItemID = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.CurrentListGUID = ((System.Guid)(this.GetVariableValue((2 + locationsOffset))));
                this.NumberOfDay = ((double)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                if (((locationReferences[(offset + 1)].Name != "CurrentListID") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Title") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "LeaveType") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "LeaveStatus") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "OfficerManager") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "listHrApprove") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.Collections.ObjectModel.Collection<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "CurrentSiteUrl") 
                            || (locationReferences[(offset + 9)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "ApproveStatus") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "dynamichr") 
                            || (locationReferences[(offset + 11)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "RequestType") 
                            || (locationReferences[(offset + 12)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "CancelLeaveStatus") 
                            || (locationReferences[(offset + 13)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "TitleManagerEmail") 
                            || (locationReferences[(offset + 14)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "BodyManagerEmail") 
                            || (locationReferences[(offset + 15)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "setStatusRequest") 
                            || (locationReferences[(offset + 16)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "RequesterId") 
                            || (locationReferences[(offset + 17)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "TitleRequesterEmail") 
                            || (locationReferences[(offset + 18)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "BodyRequesterEmail") 
                            || (locationReferences[(offset + 19)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "TitleHREmail") 
                            || (locationReferences[(offset + 20)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "BodyHrEmail") 
                            || (locationReferences[(offset + 21)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "CurrentAppUrl") 
                            || (locationReferences[(offset + 22)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "CurrentHostUrl") 
                            || (locationReferences[(offset + 23)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "CurrentUrl") 
                            || (locationReferences[(offset + 24)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "CurrentItemID") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "CurrentListGUID") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Guid)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "NumberOfDay") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                return Workflow_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext3 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext3_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext4 : Workflow_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string currentListName {
                get {
                    return ((string)(this.GetVariableValue((25 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((25 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 65 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      CurrentSiteUrl;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 65 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                      CurrentSiteUrl;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr0Set(string value) {
                
                #line 65 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                      CurrentSiteUrl = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr0Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr0Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 72 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr1Get() {
                
                #line 72 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                      CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(int value) {
                
                #line 72 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                      CurrentItemID = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 79 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      CurrentListID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 79 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                      CurrentListID;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(string value) {
                
                #line 79 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                      CurrentListID = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 86 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      currentListName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 86 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                      currentListName;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(string value) {
                
                #line 86 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                      currentListName = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 93 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                      CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr5Get() {
                
                #line 93 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                      CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(System.Guid value) {
                
                #line 93 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                      CurrentListGUID = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(System.Guid value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                if (((locationReferences[(offset + 25)].Name != "currentListName") 
                            || (locationReferences[(offset + 25)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext4_ForReadOnly : Workflow_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string currentListName {
                get {
                    return ((string)(this.GetVariableValue((25 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 98 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                      new Guid(CurrentListID);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr4Get() {
                
                #line 98 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                      new Guid(CurrentListID);
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 105 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      "List : "+CurrentListID+"\r\n"+
"ItemID : "+CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr6Get() {
                
                #line 105 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                      "List : "+CurrentListID+"\r\n"+
"ItemID : "+CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                if (((locationReferences[(offset + 25)].Name != "currentListName") 
                            || (locationReferences[(offset + 25)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext5 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext5_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext6 : Workflow_TypedDataContext5 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int iscancelstate;
            
            protected bool iscompleteParallel;
            
            public Workflow_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.ObjectModel.Collection<string> EmailToRequester {
                get {
                    return ((System.Collections.ObjectModel.Collection<string>)(this.GetVariableValue((25 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((25 + locationsOffset), value);
                }
            }
            
            protected string ExtraOwnApprove {
                get {
                    return ((string)(this.GetVariableValue((26 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((26 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 478 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                          iscancelstate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr7Get() {
                
                #line 478 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                          iscancelstate;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(int value) {
                
                #line 478 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                          iscancelstate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 488 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                          iscompleteParallel;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 488 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                          iscompleteParallel;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(bool value) {
                
                #line 488 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                          iscompleteParallel = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 931 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                  iscancelstate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr51Get() {
                
                #line 931 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                  iscancelstate;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(int value) {
                
                #line 931 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                  iscancelstate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 941 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                  iscompleteParallel;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr52Get() {
                
                #line 941 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                  iscompleteParallel;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr52Set(bool value) {
                
                #line 941 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                  iscompleteParallel = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr52Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr52Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.iscancelstate = ((int)(this.GetVariableValue((27 + locationsOffset))));
                this.iscompleteParallel = ((bool)(this.GetVariableValue((28 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((27 + locationsOffset), this.iscancelstate);
                this.SetVariableValue((28 + locationsOffset), this.iscompleteParallel);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 29))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 29);
                }
                expectedLocationsCount = 29;
                if (((locationReferences[(offset + 25)].Name != "EmailToRequester") 
                            || (locationReferences[(offset + 25)].Type != typeof(System.Collections.ObjectModel.Collection<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 26)].Name != "ExtraOwnApprove") 
                            || (locationReferences[(offset + 26)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 27)].Name != "iscancelstate") 
                            || (locationReferences[(offset + 27)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 28)].Name != "iscompleteParallel") 
                            || (locationReferences[(offset + 28)].Type != typeof(bool)))) {
                    return false;
                }
                return Workflow_TypedDataContext5.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext6_ForReadOnly : Workflow_TypedDataContext5_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int iscancelstate;
            
            protected bool iscompleteParallel;
            
            public Workflow_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.ObjectModel.Collection<string> EmailToRequester {
                get {
                    return ((System.Collections.ObjectModel.Collection<string>)(this.GetVariableValue((25 + locationsOffset))));
                }
            }
            
            protected string ExtraOwnApprove {
                get {
                    return ((string)(this.GetVariableValue((26 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 497 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                        iscompleteParallel;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr53Get() {
                
                #line 497 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                        iscompleteParallel;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 957 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      (RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1")) && iscancelstate == 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr54Get() {
                
                #line 957 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                      (RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1")) && iscancelstate == 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 1069 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      (RequestType.ToLower().Equals("cancel") || RequestType.ToLower().Equals("2") )&& iscancelstate == 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr55Get() {
                
                #line 1069 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                      (RequestType.ToLower().Equals("cancel") || RequestType.ToLower().Equals("2") )&& iscancelstate == 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 1128 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      iscancelstate == 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr56Get() {
                
                #line 1128 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                      iscancelstate == 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            protected override void GetValueTypeValues() {
                this.iscancelstate = ((int)(this.GetVariableValue((27 + locationsOffset))));
                this.iscompleteParallel = ((bool)(this.GetVariableValue((28 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 29))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 29);
                }
                expectedLocationsCount = 29;
                if (((locationReferences[(offset + 25)].Name != "EmailToRequester") 
                            || (locationReferences[(offset + 25)].Type != typeof(System.Collections.ObjectModel.Collection<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 26)].Name != "ExtraOwnApprove") 
                            || (locationReferences[(offset + 26)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 27)].Name != "iscancelstate") 
                            || (locationReferences[(offset + 27)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 28)].Name != "iscompleteParallel") 
                            || (locationReferences[(offset + 28)].Type != typeof(bool)))) {
                    return false;
                }
                return Workflow_TypedDataContext5_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext7 : Workflow_TypedDataContext6 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int errorindex;
            
            protected int errormax;
            
            protected int errorlen;
            
            public Workflow_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 523 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                                                                      EmailToRequester;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr11Get() {
                
                #line 523 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      EmailToRequester;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(System.Collections.ObjectModel.Collection<string> value) {
                
                #line 523 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                      EmailToRequester = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(System.Collections.ObjectModel.Collection<string> value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 731 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                  setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr32Get() {
                
                #line 731 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                                  setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(string value) {
                
                #line 731 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                                  setStatusRequest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 745 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                  setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr33Get() {
                
                #line 745 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                                  setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(string value) {
                
                #line 745 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                                  setStatusRequest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 758 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            ApproveStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr34Get() {
                
                #line 758 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            ApproveStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(string value) {
                
                #line 758 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                            ApproveStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 768 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            ExtraOwnApprove;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr35Get() {
                
                #line 768 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            ExtraOwnApprove;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(string value) {
                
                #line 768 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                            ExtraOwnApprove = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 800 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      iscompleteParallel;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr39Get() {
                
                #line 800 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      iscompleteParallel;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(bool value) {
                
                #line 800 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                      iscompleteParallel = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.errorindex = ((int)(this.GetVariableValue((29 + locationsOffset))));
                this.errormax = ((int)(this.GetVariableValue((30 + locationsOffset))));
                this.errorlen = ((int)(this.GetVariableValue((31 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((29 + locationsOffset), this.errorindex);
                this.SetVariableValue((30 + locationsOffset), this.errormax);
                this.SetVariableValue((31 + locationsOffset), this.errorlen);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 32))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 32);
                }
                expectedLocationsCount = 32;
                if (((locationReferences[(offset + 29)].Name != "errorindex") 
                            || (locationReferences[(offset + 29)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 30)].Name != "errormax") 
                            || (locationReferences[(offset + 30)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 31)].Name != "errorlen") 
                            || (locationReferences[(offset + 31)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow_TypedDataContext6.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext7_ForReadOnly : Workflow_TypedDataContext6_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int errorindex;
            
            protected int errormax;
            
            protected int errorlen;
            
            public Workflow_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 512 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      "--Manager ID in Send Task : "+OfficerManager+
"--HR ID in Send Task : " + listHrApprove.Count +
"--Title in Send Task : " + Title + 
"--LeaveStatus in Send Task : " + LeaveStatus + 
"--LeaveType in Send Task : " + LeaveType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr9Get() {
                
                #line 512 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      "--Manager ID in Send Task : "+OfficerManager+
"--HR ID in Send Task : " + listHrApprove.Count +
"--Title in Send Task : " + Title + 
"--LeaveStatus in Send Task : " + LeaveStatus + 
"--LeaveType in Send Task : " + LeaveType;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 528 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      RequesterId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr10Get() {
                
                #line 528 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      RequesterId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 535 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      !string.IsNullOrEmpty(OfficerManager);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 535 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      !string.IsNullOrEmpty(OfficerManager);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 723 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                            RequestType.ToLower().Equals("new");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr31Get() {
                
                #line 723 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            RequestType.ToLower().Equals("new");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 793 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                                                                      EmailToRequester;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr36Get() {
                
                #line 793 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      EmailToRequester;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 781 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      "<table style='font-family:Angsana New;font-size:26px;'><tr><td>" +
                BodyRequesterEmail +ApproveStatus+ " การขออนุมัติของท่าน " + "<a href='" + CurrentUrl + "?SPHostUrl=" + CurrentHostUrl + "&SPAppWebUrl=" + CurrentAppUrl + "&CaseView=1&CurItemId=" + CurrentItemID + "'>รายละเอียด</a>"+
"</td></tr></table>";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr37Get() {
                
                #line 781 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      "<table style='font-family:Angsana New;font-size:26px;'><tr><td>" +
                BodyRequesterEmail +ApproveStatus+ " การขออนุมัติของท่าน " + "<a href='" + CurrentUrl + "?SPHostUrl=" + CurrentHostUrl + "&SPAppWebUrl=" + CurrentAppUrl + "&CaseView=1&CurItemId=" + CurrentItemID + "'>รายละเอียด</a>"+
"</td></tr></table>";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 788 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      TitleRequesterEmail+ExtraOwnApprove;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr38Get() {
                
                #line 788 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      TitleRequesterEmail+ExtraOwnApprove;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            protected override void GetValueTypeValues() {
                this.errorindex = ((int)(this.GetVariableValue((29 + locationsOffset))));
                this.errormax = ((int)(this.GetVariableValue((30 + locationsOffset))));
                this.errorlen = ((int)(this.GetVariableValue((31 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 32))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 32);
                }
                expectedLocationsCount = 32;
                if (((locationReferences[(offset + 29)].Name != "errorindex") 
                            || (locationReferences[(offset + 29)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 30)].Name != "errormax") 
                            || (locationReferences[(offset + 30)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 31)].Name != "errorlen") 
                            || (locationReferences[(offset + 31)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow_TypedDataContext6_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext8 : Workflow_TypedDataContext7 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int outcome_0;
            
            protected int outcome_1;
            
            public Workflow_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 596 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                            outcome_0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr18Get() {
                
                #line 596 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            outcome_0;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(int value) {
                
                #line 596 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                            outcome_0 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 653 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                          setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr26Get() {
                
                #line 653 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                                          setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(string value) {
                
                #line 653 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                                          setStatusRequest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 667 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                          setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr27Get() {
                
                #line 667 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                                          setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(string value) {
                
                #line 667 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                                          setStatusRequest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 680 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                    ApproveStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr28Get() {
                
                #line 680 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                                    ApproveStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(string value) {
                
                #line 680 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                                    ApproveStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 694 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                    setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 694 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                                    setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(string value) {
                
                #line 694 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                                    setStatusRequest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 704 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                    ApproveStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 704 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                                    ApproveStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(string value) {
                
                #line 704 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                                    ApproveStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.outcome_0 = ((int)(this.GetVariableValue((32 + locationsOffset))));
                this.outcome_1 = ((int)(this.GetVariableValue((33 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((32 + locationsOffset), this.outcome_0);
                this.SetVariableValue((33 + locationsOffset), this.outcome_1);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 34))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 34);
                }
                expectedLocationsCount = 34;
                if (((locationReferences[(offset + 32)].Name != "outcome_0") 
                            || (locationReferences[(offset + 32)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 33)].Name != "outcome_1") 
                            || (locationReferences[(offset + 33)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow_TypedDataContext7.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext8_ForReadOnly : Workflow_TypedDataContext7_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int outcome_0;
            
            protected int outcome_1;
            
            public Workflow_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 548 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            TitleManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 548 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            TitleManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 555 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            BodyManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 555 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            BodyManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 567 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            "<table style='font-family:Angsana New;font-size:26px;'><tr><td>" +
  BodyManagerEmail + "  " + "<a href='" + CurrentUrl + "?SPHostUrl=" + CurrentHostUrl + "&SPAppWebUrl=" + CurrentAppUrl + "&CaseView=0&CurItemId=" + CurrentItemID + "&TaskUrl=%TaskSpecial: TaskUrl%'>รายละเอียด</a>"+
"</td></tr></table>";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 567 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            "<table style='font-family:Angsana New;font-size:26px;'><tr><td>" +
  BodyManagerEmail + "  " + "<a href='" + CurrentUrl + "?SPHostUrl=" + CurrentHostUrl + "&SPAppWebUrl=" + CurrentAppUrl + "&CaseView=0&CurItemId=" + CurrentItemID + "&TaskUrl=%TaskSpecial: TaskUrl%'>รายละเอียด</a>"+
"</td></tr></table>";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 584 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            "<table style='font-family:Angsana New;font-size:26px;'><tr><td>" +
                "เนื่องจากผู้ขออนุมัติได้ยกเลิกการขออนุมัติการลา จึงแจ้งมาเพื่อทราบ"+
"</td></tr></table>";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 584 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            "<table style='font-family:Angsana New;font-size:26px;'><tr><td>" +
                "เนื่องจากผู้ขออนุมัติได้ยกเลิกการขออนุมัติการลา จึงแจ้งมาเพื่อทราบ"+
"</td></tr></table>";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 579 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            BodyManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 579 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            BodyManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 622 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            TitleManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 622 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            TitleManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 562 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            OfficerManager;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr20Get() {
                
                #line 562 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            OfficerManager;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 574 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            TitleManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr21Get() {
                
                #line 574 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            TitleManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 591 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            "แจ้งยกเลิกการขออนุมัติการลาของ " + Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr22Get() {
                
                #line 591 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            "แจ้งยกเลิกการขออนุมัติการลาของ " + Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 629 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            "Output :" + outcome_0.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr23Get() {
                
                #line 629 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                            "Output :" + outcome_0.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 637 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              outcome_0 == 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr24Get() {
                
                #line 637 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                              outcome_0 == 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 645 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                    RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr25Get() {
                
                #line 645 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                                    RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            protected override void GetValueTypeValues() {
                this.outcome_0 = ((int)(this.GetVariableValue((32 + locationsOffset))));
                this.outcome_1 = ((int)(this.GetVariableValue((33 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 34))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 34);
                }
                expectedLocationsCount = 34;
                if (((locationReferences[(offset + 32)].Name != "outcome_0") 
                            || (locationReferences[(offset + 32)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 33)].Name != "outcome_1") 
                            || (locationReferences[(offset + 33)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow_TypedDataContext7_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext9 : Workflow_TypedDataContext7 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext9(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Exception exception {
                get {
                    return ((System.Exception)(this.GetVariableValue((32 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((32 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 828 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      errorindex;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr41Get() {
                
                #line 828 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      errorindex;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr41Set(int value) {
                
                #line 828 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                      errorindex = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr41Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr41Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 838 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      errormax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr42Get() {
                
                #line 838 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      errormax;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(int value) {
                
                #line 838 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                      errormax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 848 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      errorlen;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr44Get() {
                
                #line 848 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      errorlen;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr44Set(int value) {
                
                #line 848 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                      errorlen = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr44Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr44Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 890 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          errorindex;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr49Get() {
                
                #line 890 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                          errorindex;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr49Set(int value) {
                
                #line 890 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                          errorindex = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr49Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr49Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 33))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 33);
                }
                expectedLocationsCount = 33;
                if (((locationReferences[(offset + 32)].Name != "exception") 
                            || (locationReferences[(offset + 32)].Type != typeof(System.Exception)))) {
                    return false;
                }
                return Workflow_TypedDataContext7.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext9_ForReadOnly : Workflow_TypedDataContext7_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Exception exception {
                get {
                    return ((System.Exception)(this.GetVariableValue((32 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 821 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      "Error In Send Task :"+exception.ToString().Length;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr40Get() {
                
                #line 821 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      "Error In Send Task :"+exception.ToString().Length;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 853 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      exception.ToString().Length;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr43Get() {
                
                #line 853 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                      exception.ToString().Length;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 865 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                          (errorlen-errorindex) > errormax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr45Get() {
                
                #line 865 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                          (errorlen-errorindex) > errormax;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 872 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                              exception.ToString().Substring(errorindex,errormax);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr46Get() {
                
                #line 872 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                              exception.ToString().Substring(errorindex,errormax);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 881 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                              exception.ToString().Substring(errorindex,(errorlen-errorindex));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr47Get() {
                
                #line 881 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                              exception.ToString().Substring(errorindex,(errorlen-errorindex));
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 895 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          errorindex+errormax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr48Get() {
                
                #line 895 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                          errorindex+errormax;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 859 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                    errorindex < exception.ToString().Length;;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr50Get() {
                
                #line 859 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                    errorindex < exception.ToString().Length;;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 33))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 33);
                }
                expectedLocationsCount = 33;
                if (((locationReferences[(offset + 32)].Name != "exception") 
                            || (locationReferences[(offset + 32)].Type != typeof(System.Exception)))) {
                    return false;
                }
                return Workflow_TypedDataContext7_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext10 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext10(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext10_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext11 : Workflow_TypedDataContext10 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext11(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string LeaveDictionaryText {
                get {
                    return ((string)(this.GetVariableValue((25 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((25 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                if (((locationReferences[(offset + 25)].Name != "LeaveDictionaryText") 
                            || (locationReferences[(offset + 25)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext10.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext11_ForReadOnly : Workflow_TypedDataContext10_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string LeaveDictionaryText {
                get {
                    return ((string)(this.GetVariableValue((25 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 387 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr82Get() {
                
                #line 387 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                      RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 1257 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      RequestType.ToLower().Equals("cancel") || RequestType.ToLower().Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr83Get() {
                
                #line 1257 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                      RequestType.ToLower().Equals("cancel") || RequestType.ToLower().Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                if (((locationReferences[(offset + 25)].Name != "LeaveDictionaryText") 
                            || (locationReferences[(offset + 25)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext10_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext12 : Workflow_TypedDataContext11 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext12(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Microsoft.Activities.DynamicValue listItemProps {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((26 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((26 + locationsOffset), value);
                }
            }
            
            protected System.Collections.ObjectModel.Collection<int> testCollectionInt {
                get {
                    return ((System.Collections.ObjectModel.Collection<int>)(this.GetVariableValue((27 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((27 + locationsOffset), value);
                }
            }
            
            protected string hrarray {
                get {
                    return ((string)(this.GetVariableValue((28 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((28 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 249 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                                              listItemProps;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr58Get() {
                
                #line 249 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              listItemProps;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr58Set(Microsoft.Activities.DynamicValue value) {
                
                #line 249 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                              listItemProps = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr58Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr58Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 276 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              LeaveStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr60Get() {
                
                #line 276 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              LeaveStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr60Set(string value) {
                
                #line 276 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                              LeaveStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr60Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr60Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 279 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              RequesterId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr61Get() {
                
                #line 279 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              RequesterId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(string value) {
                
                #line 279 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                              RequesterId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 273 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              NumberOfDay;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr62Get() {
                
                #line 273 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              NumberOfDay;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr62Set(double value) {
                
                #line 273 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                              NumberOfDay = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr62Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr62Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 270 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              LeaveType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr64Get() {
                
                #line 270 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              LeaveType;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr64Set(string value) {
                
                #line 270 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                              LeaveType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr64Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr64Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 267 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr65Get() {
                
                #line 267 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr65Set(string value) {
                
                #line 267 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                              Title = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr65Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr65Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 264 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                                              dynamichr;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr66Get() {
                
                #line 264 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              dynamichr;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr66Set(Microsoft.Activities.DynamicValue value) {
                
                #line 264 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                              dynamichr = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr66Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr66Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 282 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              LeaveDictionaryText;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr67Get() {
                
                #line 282 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              LeaveDictionaryText;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr67Set(string value) {
                
                #line 282 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                              LeaveDictionaryText = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr67Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr67Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 261 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              OfficerManager;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr68Get() {
                
                #line 261 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              OfficerManager;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr68Set(string value) {
                
                #line 261 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                              OfficerManager = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr68Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr68Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 302 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                                                    listHrApprove;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr71Get() {
                
                #line 302 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    listHrApprove;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr71Set(System.Collections.ObjectModel.Collection<string> value) {
                
                #line 302 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    listHrApprove = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr71Set(System.Collections.ObjectModel.Collection<string> value) {
                this.GetValueTypeValues();
                this.@__Expr71Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 29))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 29);
                }
                expectedLocationsCount = 29;
                if (((locationReferences[(offset + 26)].Name != "listItemProps") 
                            || (locationReferences[(offset + 26)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 27)].Name != "testCollectionInt") 
                            || (locationReferences[(offset + 27)].Type != typeof(System.Collections.ObjectModel.Collection<int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 28)].Name != "hrarray") 
                            || (locationReferences[(offset + 28)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext11.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext12_ForReadOnly : Workflow_TypedDataContext11_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Microsoft.Activities.DynamicValue listItemProps {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((26 + locationsOffset))));
                }
            }
            
            protected System.Collections.ObjectModel.Collection<int> testCollectionInt {
                get {
                    return ((System.Collections.ObjectModel.Collection<int>)(this.GetVariableValue((27 + locationsOffset))));
                }
            }
            
            protected string hrarray {
                get {
                    return ((string)(this.GetVariableValue((28 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 244 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                              CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr57Get() {
                
                #line 244 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 239 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr59Get() {
                
                #line 239 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 256 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                                              listItemProps;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr63Get() {
                
                #line 256 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              listItemProps;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 289 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              dynamichr != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr69Get() {
                
                #line 289 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              dynamichr != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 297 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                                                    dynamichr;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr70Get() {
                
                #line 297 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    dynamichr;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 309 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    dynamichr.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr72Get() {
                
                #line 309 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    dynamichr.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 319 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              "RequesterId ID in Get Info : " + RequesterId +
"\r\nManager ID in Get Info : " +OfficerManager+
"\r\nHR ID in Get Info : " + listHrApprove.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr73Get() {
                
                #line 319 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              "RequesterId ID in Get Info : " + RequesterId +
"\r\nManager ID in Get Info : " +OfficerManager+
"\r\nHR ID in Get Info : " + listHrApprove.Count;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 328 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              !string.IsNullOrEmpty(LeaveDictionaryText);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr74Get() {
                
                #line 328 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                              !string.IsNullOrEmpty(LeaveDictionaryText);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 29))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 29);
                }
                expectedLocationsCount = 29;
                if (((locationReferences[(offset + 26)].Name != "listItemProps") 
                            || (locationReferences[(offset + 26)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 27)].Name != "testCollectionInt") 
                            || (locationReferences[(offset + 27)].Type != typeof(System.Collections.ObjectModel.Collection<int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 28)].Name != "hrarray") 
                            || (locationReferences[(offset + 28)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext11_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext13 : Workflow_TypedDataContext12 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext13(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string MaxValueTest {
                get {
                    return ((string)(this.GetVariableValue((29 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((29 + locationsOffset), value);
                }
            }
            
            protected Microsoft.Activities.DynamicValue LeaveDictionary {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((30 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((30 + locationsOffset), value);
                }
            }
            
            protected string LeaveTextTitle {
                get {
                    return ((string)(this.GetVariableValue((31 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((31 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 341 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                                                    LeaveDictionary;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr75Get() {
                
                #line 341 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    LeaveDictionary;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr75Set(Microsoft.Activities.DynamicValue value) {
                
                #line 341 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    LeaveDictionary = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr75Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr75Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 356 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    LeaveTextTitle;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr77Get() {
                
                #line 356 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    LeaveTextTitle;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr77Set(string value) {
                
                #line 356 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    LeaveTextTitle = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr77Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr77Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 368 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    LeaveType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr81Get() {
                
                #line 368 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    LeaveType;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr81Set(string value) {
                
                #line 368 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    LeaveType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr81Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr81Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 32))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 32);
                }
                expectedLocationsCount = 32;
                if (((locationReferences[(offset + 29)].Name != "MaxValueTest") 
                            || (locationReferences[(offset + 29)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 30)].Name != "LeaveDictionary") 
                            || (locationReferences[(offset + 30)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 31)].Name != "LeaveTextTitle") 
                            || (locationReferences[(offset + 31)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext12.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext13_ForReadOnly : Workflow_TypedDataContext12_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string MaxValueTest {
                get {
                    return ((string)(this.GetVariableValue((29 + locationsOffset))));
                }
            }
            
            protected Microsoft.Activities.DynamicValue LeaveDictionary {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((30 + locationsOffset))));
                }
            }
            
            protected string LeaveTextTitle {
                get {
                    return ((string)(this.GetVariableValue((31 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 345 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  LeaveDictionaryText;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr76Get() {
                
                #line 345 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                  LeaveDictionaryText;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 361 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                                                    LeaveDictionary;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr78Get() {
                
                #line 361 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    LeaveDictionary;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 351 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    LeaveType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr79Get() {
                
                #line 351 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    LeaveType;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 373 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    LeaveTextTitle;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr80Get() {
                
                #line 373 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    LeaveTextTitle;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 32))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 32);
                }
                expectedLocationsCount = 32;
                if (((locationReferences[(offset + 29)].Name != "MaxValueTest") 
                            || (locationReferences[(offset + 29)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 30)].Name != "LeaveDictionary") 
                            || (locationReferences[(offset + 30)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 31)].Name != "LeaveTextTitle") 
                            || (locationReferences[(offset + 31)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext12_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext14 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext14(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 213 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  ApproveStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr86Get() {
                
                #line 213 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                  ApproveStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr86Set(string value) {
                
                #line 213 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                  ApproveStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr86Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr86Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext14_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 193 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                        CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr84Get() {
                
                #line 193 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                        CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 188 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr85Get() {
                
                #line 188 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                        CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext15 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext15(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext15_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext16 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext16(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext16(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext16(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext16_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext16_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext16_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext16_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 175 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr96Get() {
                
                #line 175 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                      RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 1358 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      RequestType.ToLower().Equals("cancel")|| RequestType.ToLower().Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr97Get() {
                
                #line 1358 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                      RequestType.ToLower().Equals("cancel")|| RequestType.ToLower().Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext17 : Workflow_TypedDataContext16 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext17(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext17(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext17(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Microsoft.Activities.DynamicValue dv_0 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((25 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((25 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 136 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                          dv_0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr88Get() {
                
                #line 136 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                          dv_0;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr88Set(Microsoft.Activities.DynamicValue value) {
                
                #line 136 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                          dv_0 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr88Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr88Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 151 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          CurrentAppUrl;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr90Get() {
                
                #line 151 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                          CurrentAppUrl;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr90Set(string value) {
                
                #line 151 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                          CurrentAppUrl = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr90Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr90Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 148 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          RequestType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr91Get() {
                
                #line 148 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                          RequestType;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr91Set(string value) {
                
                #line 148 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                          RequestType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr91Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr91Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 157 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          CurrentUrl;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr92Get() {
                
                #line 157 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                          CurrentUrl;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr92Set(string value) {
                
                #line 157 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                          CurrentUrl = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr92Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr92Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr94GetTree() {
                
                #line 154 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          CurrentHostUrl;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr94Get() {
                
                #line 154 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                          CurrentHostUrl;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr94Set(string value) {
                
                #line 154 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                          CurrentHostUrl = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr94Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr94Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                if (((locationReferences[(offset + 25)].Name != "dv_0") 
                            || (locationReferences[(offset + 25)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                return Workflow_TypedDataContext16.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext17_ForReadOnly : Workflow_TypedDataContext16_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext17_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext17_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext17_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Microsoft.Activities.DynamicValue dv_0 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((25 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 131 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                          CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr87Get() {
                
                #line 131 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                          CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 126 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                          CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr89Get() {
                
                #line 126 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                          CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 143 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                          dv_0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr93Get() {
                
                #line 143 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                          dv_0;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 164 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          CurrentUrl+"\r\n"+
CurrentHostUrl + "\r\n"+
CurrentAppUrl + "\r\n";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr95Get() {
                
                #line 164 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                          CurrentUrl+"\r\n"+
CurrentHostUrl + "\r\n"+
CurrentAppUrl + "\r\n";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                if (((locationReferences[(offset + 25)].Name != "dv_0") 
                            || (locationReferences[(offset + 25)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                return Workflow_TypedDataContext16_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext18 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext18(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext18(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext18(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 1396 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  ApproveStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr100Get() {
                
                #line 1396 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                  ApproveStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr100Set(string value) {
                
                #line 1396 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                  ApproveStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr100Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr100Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext18_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext18_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext18_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext18_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 1376 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                        CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr98Get() {
                
                #line 1376 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                        CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 1371 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr99Get() {
                
                #line 1371 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                        CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext19 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext19(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext19(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext19(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext19_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext19_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext19_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext19_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 1017 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                          listHrApprove.Count > 0 && ApproveStatus.Equals("Approved");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr101Get() {
                
                #line 1017 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                          listHrApprove.Count > 0 && ApproveStatus.Equals("Approved");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext20 : Workflow_TypedDataContext19 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int outcom_hr;
            
            public Workflow_TypedDataContext20(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext20(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext20(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.outcom_hr = ((int)(this.GetVariableValue((25 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((25 + locationsOffset), this.outcom_hr);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                if (((locationReferences[(offset + 25)].Name != "outcom_hr") 
                            || (locationReferences[(offset + 25)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow_TypedDataContext19.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext20_ForReadOnly : Workflow_TypedDataContext19_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int outcom_hr;
            
            public Workflow_TypedDataContext20_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext20_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext20_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 1040 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                                                                                listHrApprove;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr102Get() {
                
                #line 1040 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                                listHrApprove;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 1028 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                "<table style='font-family:Angsana New;font-size:26px;'><tr><td>" +
                BodyHrEmail + ApproveStatus + "  " + "<a href='" + CurrentUrl + "?SPHostUrl=" + CurrentHostUrl + "&SPAppWebUrl=" + CurrentAppUrl + "&CaseView=2&CurItemId=" + CurrentItemID + "'>รายละเอียด</a>"+
"</td></tr></table>";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr103Get() {
                
                #line 1028 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                                "<table style='font-family:Angsana New;font-size:26px;'><tr><td>" +
                BodyHrEmail + ApproveStatus + "  " + "<a href='" + CurrentUrl + "?SPHostUrl=" + CurrentHostUrl + "&SPAppWebUrl=" + CurrentAppUrl + "&CaseView=2&CurItemId=" + CurrentItemID + "'>รายละเอียด</a>"+
"</td></tr></table>";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 1035 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                TitleHREmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr104Get() {
                
                #line 1035 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                                TitleHREmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            protected override void GetValueTypeValues() {
                this.outcom_hr = ((int)(this.GetVariableValue((25 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                if (((locationReferences[(offset + 25)].Name != "outcom_hr") 
                            || (locationReferences[(offset + 25)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow_TypedDataContext19_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext21 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext21(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext21(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext21(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 397 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    TitleManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr106Get() {
                
                #line 397 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    TitleManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr106Get() {
                this.GetValueTypeValues();
                return this.@__Expr106Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr106Set(string value) {
                
                #line 397 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    TitleManagerEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr106Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr106Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 409 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    BodyManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr108Get() {
                
                #line 409 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    BodyManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr108Set(string value) {
                
                #line 409 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    BodyManagerEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr108Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr108Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 423 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    TitleRequesterEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr109Get() {
                
                #line 423 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    TitleRequesterEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr109Set(string value) {
                
                #line 423 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    TitleRequesterEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr109Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr109Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr110GetTree() {
                
                #line 433 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    BodyRequesterEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr110Get() {
                
                #line 433 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    BodyRequesterEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr110Get() {
                this.GetValueTypeValues();
                return this.@__Expr110Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr110Set(string value) {
                
                #line 433 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    BodyRequesterEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr110Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr110Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr112GetTree() {
                
                #line 445 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    TitleHREmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr112Get() {
                
                #line 445 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    TitleHREmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr112Get() {
                this.GetValueTypeValues();
                return this.@__Expr112Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr112Set(string value) {
                
                #line 445 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    TitleHREmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr112Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr112Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr114GetTree() {
                
                #line 457 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    BodyHrEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr114Get() {
                
                #line 457 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    BodyHrEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr114Get() {
                this.GetValueTypeValues();
                return this.@__Expr114Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr114Set(string value) {
                
                #line 457 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    BodyHrEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr114Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr114Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext21_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext21_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext21_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext21_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 402 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "แจ้งการขออนุมัติการลาของ " + Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr105Get() {
                
                #line 402 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    "แจ้งการขออนุมัติการลาของ " + Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 414 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "กรุณาพิจารณา การลา " + LeaveType + " ของ " +Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr107Get() {
                
                #line 414 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    "กรุณาพิจารณา การลา " + LeaveType + " ของ " +Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr111GetTree() {
                
                #line 450 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Review : แจ้งผลการขออนุมัติการลาของ "+Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr111Get() {
                
                #line 450 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    "Review : แจ้งผลการขออนุมัติการลาของ "+Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr111Get() {
                this.GetValueTypeValues();
                return this.@__Expr111Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 462 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "ตามที่ "+ Title + "ได้ขออนุมัติการลา "+LeaveType+" โดยมีผลการพิจารณา คือ ";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr113Get() {
                
                #line 462 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    "ตามที่ "+ Title + "ได้ขออนุมัติการลา "+LeaveType+" โดยมีผลการพิจารณา คือ ";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr113Get() {
                this.GetValueTypeValues();
                return this.@__Expr113Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext22 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext22(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext22(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext22(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr116GetTree() {
                
                #line 1267 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    TitleManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr116Get() {
                
                #line 1267 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    TitleManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr116Get() {
                this.GetValueTypeValues();
                return this.@__Expr116Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr116Set(string value) {
                
                #line 1267 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    TitleManagerEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr116Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr116Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr118GetTree() {
                
                #line 1279 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    BodyManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr118Get() {
                
                #line 1279 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    BodyManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr118Get() {
                this.GetValueTypeValues();
                return this.@__Expr118Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr118Set(string value) {
                
                #line 1279 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    BodyManagerEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr118Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr118Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr119GetTree() {
                
                #line 1293 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    TitleRequesterEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr119Get() {
                
                #line 1293 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    TitleRequesterEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr119Get() {
                this.GetValueTypeValues();
                return this.@__Expr119Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr119Set(string value) {
                
                #line 1293 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    TitleRequesterEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr119Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr119Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr120GetTree() {
                
                #line 1303 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    BodyRequesterEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr120Get() {
                
                #line 1303 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    BodyRequesterEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr120Get() {
                this.GetValueTypeValues();
                return this.@__Expr120Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr120Set(string value) {
                
                #line 1303 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    BodyRequesterEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr120Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr120Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr122GetTree() {
                
                #line 1315 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    TitleHREmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr122Get() {
                
                #line 1315 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    TitleHREmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr122Get() {
                this.GetValueTypeValues();
                return this.@__Expr122Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr122Set(string value) {
                
                #line 1315 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    TitleHREmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr122Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr122Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr124GetTree() {
                
                #line 1327 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    BodyHrEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr124Get() {
                
                #line 1327 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    BodyHrEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr124Get() {
                this.GetValueTypeValues();
                return this.@__Expr124Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr124Set(string value) {
                
                #line 1327 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                    BodyHrEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr124Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr124Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext22_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext22_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext22_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext22_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 1272 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "แจ้งการขออนุมัติยกเลิกการลาของ " + Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr115Get() {
                
                #line 1272 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    "แจ้งการขออนุมัติยกเลิกการลาของ " + Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr117GetTree() {
                
                #line 1284 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "กรุณาพิจารณา ยกเลิกการลา " + LeaveType + " ของ " + Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr117Get() {
                
                #line 1284 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    "กรุณาพิจารณา ยกเลิกการลา " + LeaveType + " ของ " + Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr117Get() {
                this.GetValueTypeValues();
                return this.@__Expr117Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr121GetTree() {
                
                #line 1320 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Review : แจ้งผลการขออนุมัติยกเลิกการลาของ " + Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr121Get() {
                
                #line 1320 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    "Review : แจ้งผลการขออนุมัติยกเลิกการลาของ " + Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr121Get() {
                this.GetValueTypeValues();
                return this.@__Expr121Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr123GetTree() {
                
                #line 1332 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "ตามที่ " + Title + "ได้ขออนุมัติยกเลิกการลา " + LeaveType + " โดยมีผลการพิจารณา คือ ";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr123Get() {
                
                #line 1332 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                    "ตามที่ " + Title + "ได้ขออนุมัติยกเลิกการลา " + LeaveType + " โดยมีผลการพิจารณา คือ ";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr123Get() {
                this.GetValueTypeValues();
                return this.@__Expr123Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext23 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext23(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext23(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext23(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext23_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext23_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext23_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext23_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr125GetTree() {
                
                #line 1081 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        "Set Status to : "+setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr125Get() {
                
                #line 1081 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                        "Set Status to : "+setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr125Get() {
                this.GetValueTypeValues();
                return this.@__Expr125Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr126GetTree() {
                
                #line 1101 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                              setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr126Get() {
                
                #line 1101 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                              setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr126Get() {
                this.GetValueTypeValues();
                return this.@__Expr126Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr127GetTree() {
                
                #line 1093 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                                                        CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr127Get() {
                
                #line 1093 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                        CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr127Get() {
                this.GetValueTypeValues();
                return this.@__Expr127Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr128GetTree() {
                
                #line 1088 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                        CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr128Get() {
                
                #line 1088 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                        CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr128Get() {
                this.GetValueTypeValues();
                return this.@__Expr128Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr129GetTree() {
                
                #line 1111 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr129Get() {
                
                #line 1111 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                        setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr129Get() {
                this.GetValueTypeValues();
                return this.@__Expr129Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext24 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext24(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext24(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext24(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext24_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext24_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext24_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext24_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr130GetTree() {
                
                #line 969 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        "Set Status to : "+setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr130Get() {
                
                #line 969 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                        "Set Status to : "+setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr130Get() {
                this.GetValueTypeValues();
                return this.@__Expr130Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr131GetTree() {
                
                #line 989 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                              setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr131Get() {
                
                #line 989 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                              setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr131Get() {
                this.GetValueTypeValues();
                return this.@__Expr131Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr132GetTree() {
                
                #line 981 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                                                        CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr132Get() {
                
                #line 981 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                        CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr132Get() {
                this.GetValueTypeValues();
                return this.@__Expr132Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr133GetTree() {
                
                #line 976 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                        CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr133Get() {
                
                #line 976 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                        CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr133Get() {
                this.GetValueTypeValues();
                return this.@__Expr133Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr134GetTree() {
                
                #line 999 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr134Get() {
                
                #line 999 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                        setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr134Get() {
                this.GetValueTypeValues();
                return this.@__Expr134Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext25 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext25(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext25(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext25(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr135GetTree() {
                
                #line 1140 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr135Get() {
                
                #line 1140 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                        setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr135Get() {
                this.GetValueTypeValues();
                return this.@__Expr135Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr135Set(string value) {
                
                #line 1140 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                
                                                                        setStatusRequest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr135Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr135Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext25_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext25_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext25_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext25_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr136GetTree() {
                
                #line 1151 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          "Set Status to : "+setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr136Get() {
                
                #line 1151 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                          "Set Status to : "+setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr136Get() {
                this.GetValueTypeValues();
                return this.@__Expr136Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr137GetTree() {
                
                #line 1158 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                          RequestType.ToLower().Equals("new");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr137Get() {
                
                #line 1158 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                          RequestType.ToLower().Equals("new");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr137Get() {
                this.GetValueTypeValues();
                return this.@__Expr137Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr138GetTree() {
                
                #line 1178 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                    setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr138Get() {
                
                #line 1178 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                                    setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr138Get() {
                this.GetValueTypeValues();
                return this.@__Expr138Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr139GetTree() {
                
                #line 1170 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                                                              CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr139Get() {
                
                #line 1170 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                              CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr139Get() {
                this.GetValueTypeValues();
                return this.@__Expr139Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr140GetTree() {
                
                #line 1165 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr140Get() {
                
                #line 1165 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                              CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr140Get() {
                this.GetValueTypeValues();
                return this.@__Expr140Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr141GetTree() {
                
                #line 1201 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                                                              CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr141Get() {
                
                #line 1201 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                              CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr141Get() {
                this.GetValueTypeValues();
                return this.@__Expr141Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr142GetTree() {
                
                #line 1196 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr142Get() {
                
                #line 1196 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                              CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr142Get() {
                this.GetValueTypeValues();
                return this.@__Expr142Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr143GetTree() {
                
                #line 1224 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr143Get() {
                
                #line 1224 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWFV1\WORKFLOW.XAML"
                return 
                                                                          setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr143Get() {
                this.GetValueTypeValues();
                return this.@__Expr143Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
