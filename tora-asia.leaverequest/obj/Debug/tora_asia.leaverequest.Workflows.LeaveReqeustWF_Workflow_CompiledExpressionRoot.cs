namespace tora_asia.leaverequest.Workflows.LeaveReqeustWF {
    
    #line 18 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWF\Workflow.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWF\Workflow.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 19 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWF\Workflow.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWF\Workflow.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWF\Workflow.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWF\Workflow.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 20 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWF\Workflow.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 21 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWF\Workflow.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 22 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWF\Workflow.xaml"
    using System.Collections.ObjectModel;
    
    #line default
    #line hidden
    
    #line 23 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWF\Workflow.xaml"
    using Microsoft.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkSpace\TORA-ASIA\LeaveRequest\Repo\leaverequest-demo\tora-asia.leaverequest\Workflows\LeaveReqeustWF\Workflow.xaml"
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
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext4(locations, activityContext, true);
                }
                Workflow_TypedDataContext4 refDataContext0 = ((Workflow_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<string>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext4(locations, activityContext, true);
                }
                Workflow_TypedDataContext4 refDataContext1 = ((Workflow_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext1.GetLocation<int>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext4(locations, activityContext, true);
                }
                Workflow_TypedDataContext4 refDataContext2 = ((Workflow_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext2.GetLocation<string>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext4(locations, activityContext, true);
                }
                Workflow_TypedDataContext4 refDataContext3 = ((Workflow_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext4_ForReadOnly valDataContext4 = ((Workflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext4(locations, activityContext, true);
                }
                Workflow_TypedDataContext4 refDataContext5 = ((Workflow_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext5.GetLocation<System.Guid>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext4_ForReadOnly valDataContext6 = ((Workflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow_TypedDataContext6(locations, activityContext, true);
                }
                Workflow_TypedDataContext6 refDataContext7 = ((Workflow_TypedDataContext6)(cachedCompiledDataContext[2]));
                return refDataContext7.GetLocation<int>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow_TypedDataContext6(locations, activityContext, true);
                }
                Workflow_TypedDataContext6 refDataContext8 = ((Workflow_TypedDataContext6)(cachedCompiledDataContext[2]));
                return refDataContext8.GetLocation<bool>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext9 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext10 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext7(locations, activityContext, true);
                }
                Workflow_TypedDataContext7 refDataContext11 = ((Workflow_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext11.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext12 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext13 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext14 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext15 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext16 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow_TypedDataContext8(locations, activityContext, true);
                }
                Workflow_TypedDataContext8 refDataContext17 = ((Workflow_TypedDataContext8)(cachedCompiledDataContext[6]));
                return refDataContext17.GetLocation<int>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext18 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext19 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext20 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext21 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext22 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext23 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext8_ForReadOnly valDataContext24 = ((Workflow_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow_TypedDataContext8(locations, activityContext, true);
                }
                Workflow_TypedDataContext8 refDataContext25 = ((Workflow_TypedDataContext8)(cachedCompiledDataContext[6]));
                return refDataContext25.GetLocation<string>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow_TypedDataContext8(locations, activityContext, true);
                }
                Workflow_TypedDataContext8 refDataContext26 = ((Workflow_TypedDataContext8)(cachedCompiledDataContext[6]));
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow_TypedDataContext8(locations, activityContext, true);
                }
                Workflow_TypedDataContext8 refDataContext27 = ((Workflow_TypedDataContext8)(cachedCompiledDataContext[6]));
                return refDataContext27.GetLocation<string>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow_TypedDataContext8(locations, activityContext, true);
                }
                Workflow_TypedDataContext8 refDataContext28 = ((Workflow_TypedDataContext8)(cachedCompiledDataContext[6]));
                return refDataContext28.GetLocation<string>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow_TypedDataContext8(locations, activityContext, true);
                }
                Workflow_TypedDataContext8 refDataContext29 = ((Workflow_TypedDataContext8)(cachedCompiledDataContext[6]));
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext30 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext7(locations, activityContext, true);
                }
                Workflow_TypedDataContext7 refDataContext31 = ((Workflow_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext31.GetLocation<string>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext7(locations, activityContext, true);
                }
                Workflow_TypedDataContext7 refDataContext32 = ((Workflow_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext32.GetLocation<string>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext7(locations, activityContext, true);
                }
                Workflow_TypedDataContext7 refDataContext33 = ((Workflow_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext33.GetLocation<string>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext7(locations, activityContext, true);
                }
                Workflow_TypedDataContext7 refDataContext34 = ((Workflow_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext34.GetLocation<string>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext35 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext36 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext7_ForReadOnly valDataContext37 = ((Workflow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext7(locations, activityContext, true);
                }
                Workflow_TypedDataContext7 refDataContext38 = ((Workflow_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext38.GetLocation<bool>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext39 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow_TypedDataContext9(locations, activityContext, true);
                }
                Workflow_TypedDataContext9 refDataContext40 = ((Workflow_TypedDataContext9)(cachedCompiledDataContext[8]));
                return refDataContext40.GetLocation<int>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow_TypedDataContext9(locations, activityContext, true);
                }
                Workflow_TypedDataContext9 refDataContext41 = ((Workflow_TypedDataContext9)(cachedCompiledDataContext[8]));
                return refDataContext41.GetLocation<int>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext42 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow_TypedDataContext9(locations, activityContext, true);
                }
                Workflow_TypedDataContext9 refDataContext43 = ((Workflow_TypedDataContext9)(cachedCompiledDataContext[8]));
                return refDataContext43.GetLocation<int>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext44 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext45 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext46 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext47 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow_TypedDataContext9(locations, activityContext, true);
                }
                Workflow_TypedDataContext9 refDataContext48 = ((Workflow_TypedDataContext9)(cachedCompiledDataContext[8]));
                return refDataContext48.GetLocation<int>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext9_ForReadOnly valDataContext49 = ((Workflow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow_TypedDataContext6(locations, activityContext, true);
                }
                Workflow_TypedDataContext6 refDataContext50 = ((Workflow_TypedDataContext6)(cachedCompiledDataContext[2]));
                return refDataContext50.GetLocation<int>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow_TypedDataContext6(locations, activityContext, true);
                }
                Workflow_TypedDataContext6 refDataContext51 = ((Workflow_TypedDataContext6)(cachedCompiledDataContext[2]));
                return refDataContext51.GetLocation<bool>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext6_ForReadOnly valDataContext52 = ((Workflow_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext6_ForReadOnly valDataContext53 = ((Workflow_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext6_ForReadOnly valDataContext54 = ((Workflow_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext6_ForReadOnly valDataContext55 = ((Workflow_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext11_ForReadOnly valDataContext56 = ((Workflow_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext11(locations, activityContext, true);
                }
                Workflow_TypedDataContext11 refDataContext57 = ((Workflow_TypedDataContext11)(cachedCompiledDataContext[11]));
                return refDataContext57.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext11_ForReadOnly valDataContext58 = ((Workflow_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext11(locations, activityContext, true);
                }
                Workflow_TypedDataContext11 refDataContext59 = ((Workflow_TypedDataContext11)(cachedCompiledDataContext[11]));
                return refDataContext59.GetLocation<string>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext11(locations, activityContext, true);
                }
                Workflow_TypedDataContext11 refDataContext60 = ((Workflow_TypedDataContext11)(cachedCompiledDataContext[11]));
                return refDataContext60.GetLocation<string>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext11(locations, activityContext, true);
                }
                Workflow_TypedDataContext11 refDataContext61 = ((Workflow_TypedDataContext11)(cachedCompiledDataContext[11]));
                return refDataContext61.GetLocation<double>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext11_ForReadOnly valDataContext62 = ((Workflow_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext11(locations, activityContext, true);
                }
                Workflow_TypedDataContext11 refDataContext63 = ((Workflow_TypedDataContext11)(cachedCompiledDataContext[11]));
                return refDataContext63.GetLocation<string>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext11(locations, activityContext, true);
                }
                Workflow_TypedDataContext11 refDataContext64 = ((Workflow_TypedDataContext11)(cachedCompiledDataContext[11]));
                return refDataContext64.GetLocation<string>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext11(locations, activityContext, true);
                }
                Workflow_TypedDataContext11 refDataContext65 = ((Workflow_TypedDataContext11)(cachedCompiledDataContext[11]));
                return refDataContext65.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext11(locations, activityContext, true);
                }
                Workflow_TypedDataContext11 refDataContext66 = ((Workflow_TypedDataContext11)(cachedCompiledDataContext[11]));
                return refDataContext66.GetLocation<string>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext11_ForReadOnly valDataContext67 = ((Workflow_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext11_ForReadOnly valDataContext68 = ((Workflow_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow_TypedDataContext11(locations, activityContext, true);
                }
                Workflow_TypedDataContext11 refDataContext69 = ((Workflow_TypedDataContext11)(cachedCompiledDataContext[11]));
                return refDataContext69.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext11_ForReadOnly valDataContext70 = ((Workflow_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext11_ForReadOnly valDataContext71 = ((Workflow_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Workflow_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext10_ForReadOnly valDataContext72 = ((Workflow_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Workflow_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext10_ForReadOnly valDataContext73 = ((Workflow_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Workflow_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext12_ForReadOnly valDataContext74 = ((Workflow_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Workflow_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext12_ForReadOnly valDataContext75 = ((Workflow_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Workflow_TypedDataContext12(locations, activityContext, true);
                }
                Workflow_TypedDataContext12 refDataContext76 = ((Workflow_TypedDataContext12)(cachedCompiledDataContext[14]));
                return refDataContext76.GetLocation<string>(refDataContext76.ValueType___Expr76Get, refDataContext76.ValueType___Expr76Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Workflow_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext15_ForReadOnly valDataContext77 = ((Workflow_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Workflow_TypedDataContext15(locations, activityContext, true);
                }
                Workflow_TypedDataContext15 refDataContext78 = ((Workflow_TypedDataContext15)(cachedCompiledDataContext[16]));
                return refDataContext78.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Workflow_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext15_ForReadOnly valDataContext79 = ((Workflow_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext79.ValueType___Expr79Get();
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Workflow_TypedDataContext15(locations, activityContext, true);
                }
                Workflow_TypedDataContext15 refDataContext80 = ((Workflow_TypedDataContext15)(cachedCompiledDataContext[16]));
                return refDataContext80.GetLocation<string>(refDataContext80.ValueType___Expr80Get, refDataContext80.ValueType___Expr80Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Workflow_TypedDataContext15(locations, activityContext, true);
                }
                Workflow_TypedDataContext15 refDataContext81 = ((Workflow_TypedDataContext15)(cachedCompiledDataContext[16]));
                return refDataContext81.GetLocation<string>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Workflow_TypedDataContext15(locations, activityContext, true);
                }
                Workflow_TypedDataContext15 refDataContext82 = ((Workflow_TypedDataContext15)(cachedCompiledDataContext[16]));
                return refDataContext82.GetLocation<string>(refDataContext82.ValueType___Expr82Get, refDataContext82.ValueType___Expr82Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Workflow_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext15_ForReadOnly valDataContext83 = ((Workflow_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Workflow_TypedDataContext15(locations, activityContext, true);
                }
                Workflow_TypedDataContext15 refDataContext84 = ((Workflow_TypedDataContext15)(cachedCompiledDataContext[16]));
                return refDataContext84.GetLocation<string>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Workflow_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext15_ForReadOnly valDataContext85 = ((Workflow_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Workflow_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext14_ForReadOnly valDataContext86 = ((Workflow_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Workflow_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext14_ForReadOnly valDataContext87 = ((Workflow_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new Workflow_TypedDataContext16_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext16_ForReadOnly valDataContext88 = ((Workflow_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[18]));
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext16_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new Workflow_TypedDataContext16_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext16_ForReadOnly valDataContext89 = ((Workflow_TypedDataContext16_ForReadOnly)(cachedCompiledDataContext[18]));
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext16.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new Workflow_TypedDataContext16(locations, activityContext, true);
                }
                Workflow_TypedDataContext16 refDataContext90 = ((Workflow_TypedDataContext16)(cachedCompiledDataContext[19]));
                return refDataContext90.GetLocation<string>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext17_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Workflow_TypedDataContext17_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext17_ForReadOnly valDataContext91 = ((Workflow_TypedDataContext17_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new Workflow_TypedDataContext18_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext18_ForReadOnly valDataContext92 = ((Workflow_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext92.ValueType___Expr92Get();
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new Workflow_TypedDataContext18_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext18_ForReadOnly valDataContext93 = ((Workflow_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext18_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new Workflow_TypedDataContext18_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext18_ForReadOnly valDataContext94 = ((Workflow_TypedDataContext18_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext19_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new Workflow_TypedDataContext19_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext19_ForReadOnly valDataContext95 = ((Workflow_TypedDataContext19_ForReadOnly)(cachedCompiledDataContext[22]));
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext19.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new Workflow_TypedDataContext19(locations, activityContext, true);
                }
                Workflow_TypedDataContext19 refDataContext96 = ((Workflow_TypedDataContext19)(cachedCompiledDataContext[23]));
                return refDataContext96.GetLocation<string>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext19_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new Workflow_TypedDataContext19_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext19_ForReadOnly valDataContext97 = ((Workflow_TypedDataContext19_ForReadOnly)(cachedCompiledDataContext[22]));
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext19.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new Workflow_TypedDataContext19(locations, activityContext, true);
                }
                Workflow_TypedDataContext19 refDataContext98 = ((Workflow_TypedDataContext19)(cachedCompiledDataContext[23]));
                return refDataContext98.GetLocation<string>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext19.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new Workflow_TypedDataContext19(locations, activityContext, true);
                }
                Workflow_TypedDataContext19 refDataContext99 = ((Workflow_TypedDataContext19)(cachedCompiledDataContext[23]));
                return refDataContext99.GetLocation<string>(refDataContext99.ValueType___Expr99Get, refDataContext99.ValueType___Expr99Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext19.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new Workflow_TypedDataContext19(locations, activityContext, true);
                }
                Workflow_TypedDataContext19 refDataContext100 = ((Workflow_TypedDataContext19)(cachedCompiledDataContext[23]));
                return refDataContext100.GetLocation<string>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext19_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new Workflow_TypedDataContext19_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext19_ForReadOnly valDataContext101 = ((Workflow_TypedDataContext19_ForReadOnly)(cachedCompiledDataContext[22]));
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext19.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new Workflow_TypedDataContext19(locations, activityContext, true);
                }
                Workflow_TypedDataContext19 refDataContext102 = ((Workflow_TypedDataContext19)(cachedCompiledDataContext[23]));
                return refDataContext102.GetLocation<string>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext19_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new Workflow_TypedDataContext19_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext19_ForReadOnly valDataContext103 = ((Workflow_TypedDataContext19_ForReadOnly)(cachedCompiledDataContext[22]));
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext19.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new Workflow_TypedDataContext19(locations, activityContext, true);
                }
                Workflow_TypedDataContext19 refDataContext104 = ((Workflow_TypedDataContext19)(cachedCompiledDataContext[23]));
                return refDataContext104.GetLocation<string>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new Workflow_TypedDataContext20_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext20_ForReadOnly valDataContext105 = ((Workflow_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new Workflow_TypedDataContext20(locations, activityContext, true);
                }
                Workflow_TypedDataContext20 refDataContext106 = ((Workflow_TypedDataContext20)(cachedCompiledDataContext[25]));
                return refDataContext106.GetLocation<string>(refDataContext106.ValueType___Expr106Get, refDataContext106.ValueType___Expr106Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new Workflow_TypedDataContext20_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext20_ForReadOnly valDataContext107 = ((Workflow_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new Workflow_TypedDataContext20(locations, activityContext, true);
                }
                Workflow_TypedDataContext20 refDataContext108 = ((Workflow_TypedDataContext20)(cachedCompiledDataContext[25]));
                return refDataContext108.GetLocation<string>(refDataContext108.ValueType___Expr108Get, refDataContext108.ValueType___Expr108Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new Workflow_TypedDataContext20(locations, activityContext, true);
                }
                Workflow_TypedDataContext20 refDataContext109 = ((Workflow_TypedDataContext20)(cachedCompiledDataContext[25]));
                return refDataContext109.GetLocation<string>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new Workflow_TypedDataContext20(locations, activityContext, true);
                }
                Workflow_TypedDataContext20 refDataContext110 = ((Workflow_TypedDataContext20)(cachedCompiledDataContext[25]));
                return refDataContext110.GetLocation<string>(refDataContext110.ValueType___Expr110Get, refDataContext110.ValueType___Expr110Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new Workflow_TypedDataContext20_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext20_ForReadOnly valDataContext111 = ((Workflow_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext111.ValueType___Expr111Get();
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new Workflow_TypedDataContext20(locations, activityContext, true);
                }
                Workflow_TypedDataContext20 refDataContext112 = ((Workflow_TypedDataContext20)(cachedCompiledDataContext[25]));
                return refDataContext112.GetLocation<string>(refDataContext112.ValueType___Expr112Get, refDataContext112.ValueType___Expr112Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new Workflow_TypedDataContext20_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext20_ForReadOnly valDataContext113 = ((Workflow_TypedDataContext20_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext20.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[25] == null)) {
                    cachedCompiledDataContext[25] = new Workflow_TypedDataContext20(locations, activityContext, true);
                }
                Workflow_TypedDataContext20 refDataContext114 = ((Workflow_TypedDataContext20)(cachedCompiledDataContext[25]));
                return refDataContext114.GetLocation<string>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[26] == null)) {
                    cachedCompiledDataContext[26] = new Workflow_TypedDataContext21_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext21_ForReadOnly valDataContext115 = ((Workflow_TypedDataContext21_ForReadOnly)(cachedCompiledDataContext[26]));
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[26] == null)) {
                    cachedCompiledDataContext[26] = new Workflow_TypedDataContext21_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext21_ForReadOnly valDataContext116 = ((Workflow_TypedDataContext21_ForReadOnly)(cachedCompiledDataContext[26]));
                return valDataContext116.ValueType___Expr116Get();
            }
            if ((expressionId == 117)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[26] == null)) {
                    cachedCompiledDataContext[26] = new Workflow_TypedDataContext21_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext21_ForReadOnly valDataContext117 = ((Workflow_TypedDataContext21_ForReadOnly)(cachedCompiledDataContext[26]));
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[26] == null)) {
                    cachedCompiledDataContext[26] = new Workflow_TypedDataContext21_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext21_ForReadOnly valDataContext118 = ((Workflow_TypedDataContext21_ForReadOnly)(cachedCompiledDataContext[26]));
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext21_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[26] == null)) {
                    cachedCompiledDataContext[26] = new Workflow_TypedDataContext21_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext21_ForReadOnly valDataContext119 = ((Workflow_TypedDataContext21_ForReadOnly)(cachedCompiledDataContext[26]));
                return valDataContext119.ValueType___Expr119Get();
            }
            if ((expressionId == 120)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[27] == null)) {
                    cachedCompiledDataContext[27] = new Workflow_TypedDataContext22_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext22_ForReadOnly valDataContext120 = ((Workflow_TypedDataContext22_ForReadOnly)(cachedCompiledDataContext[27]));
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[27] == null)) {
                    cachedCompiledDataContext[27] = new Workflow_TypedDataContext22_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext22_ForReadOnly valDataContext121 = ((Workflow_TypedDataContext22_ForReadOnly)(cachedCompiledDataContext[27]));
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[27] == null)) {
                    cachedCompiledDataContext[27] = new Workflow_TypedDataContext22_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext22_ForReadOnly valDataContext122 = ((Workflow_TypedDataContext22_ForReadOnly)(cachedCompiledDataContext[27]));
                return valDataContext122.ValueType___Expr122Get();
            }
            if ((expressionId == 123)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[27] == null)) {
                    cachedCompiledDataContext[27] = new Workflow_TypedDataContext22_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext22_ForReadOnly valDataContext123 = ((Workflow_TypedDataContext22_ForReadOnly)(cachedCompiledDataContext[27]));
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext22_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[27] == null)) {
                    cachedCompiledDataContext[27] = new Workflow_TypedDataContext22_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext22_ForReadOnly valDataContext124 = ((Workflow_TypedDataContext22_ForReadOnly)(cachedCompiledDataContext[27]));
                return valDataContext124.ValueType___Expr124Get();
            }
            if ((expressionId == 125)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[28] == null)) {
                    cachedCompiledDataContext[28] = new Workflow_TypedDataContext23(locations, activityContext, true);
                }
                Workflow_TypedDataContext23 refDataContext125 = ((Workflow_TypedDataContext23)(cachedCompiledDataContext[28]));
                return refDataContext125.GetLocation<string>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 126)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext126 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext127 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext127.ValueType___Expr127Get();
            }
            if ((expressionId == 128)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext128 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext129 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext129.ValueType___Expr129Get();
            }
            if ((expressionId == 130)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext130 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext131 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext132 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext132.ValueType___Expr132Get();
            }
            if ((expressionId == 133)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext23_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 30);
                if ((cachedCompiledDataContext[29] == null)) {
                    cachedCompiledDataContext[29] = new Workflow_TypedDataContext23_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext23_ForReadOnly valDataContext133 = ((Workflow_TypedDataContext23_ForReadOnly)(cachedCompiledDataContext[29]));
                return valDataContext133.ValueType___Expr133Get();
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
                Workflow_TypedDataContext8 refDataContext17 = new Workflow_TypedDataContext8(locations, true);
                return refDataContext17.GetLocation<int>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                Workflow_TypedDataContext8_ForReadOnly valDataContext18 = new Workflow_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
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
                Workflow_TypedDataContext8 refDataContext25 = new Workflow_TypedDataContext8(locations, true);
                return refDataContext25.GetLocation<string>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
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
                Workflow_TypedDataContext7_ForReadOnly valDataContext30 = new Workflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                Workflow_TypedDataContext7 refDataContext31 = new Workflow_TypedDataContext7(locations, true);
                return refDataContext31.GetLocation<string>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
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
                Workflow_TypedDataContext7_ForReadOnly valDataContext35 = new Workflow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
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
                Workflow_TypedDataContext7 refDataContext38 = new Workflow_TypedDataContext7(locations, true);
                return refDataContext38.GetLocation<bool>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
            }
            if ((expressionId == 39)) {
                Workflow_TypedDataContext9_ForReadOnly valDataContext39 = new Workflow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                Workflow_TypedDataContext9 refDataContext40 = new Workflow_TypedDataContext9(locations, true);
                return refDataContext40.GetLocation<int>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set);
            }
            if ((expressionId == 41)) {
                Workflow_TypedDataContext9 refDataContext41 = new Workflow_TypedDataContext9(locations, true);
                return refDataContext41.GetLocation<int>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set);
            }
            if ((expressionId == 42)) {
                Workflow_TypedDataContext9_ForReadOnly valDataContext42 = new Workflow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                Workflow_TypedDataContext9 refDataContext43 = new Workflow_TypedDataContext9(locations, true);
                return refDataContext43.GetLocation<int>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                Workflow_TypedDataContext9_ForReadOnly valDataContext44 = new Workflow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
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
                Workflow_TypedDataContext9 refDataContext48 = new Workflow_TypedDataContext9(locations, true);
                return refDataContext48.GetLocation<int>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set);
            }
            if ((expressionId == 49)) {
                Workflow_TypedDataContext9_ForReadOnly valDataContext49 = new Workflow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                Workflow_TypedDataContext6 refDataContext50 = new Workflow_TypedDataContext6(locations, true);
                return refDataContext50.GetLocation<int>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set);
            }
            if ((expressionId == 51)) {
                Workflow_TypedDataContext6 refDataContext51 = new Workflow_TypedDataContext6(locations, true);
                return refDataContext51.GetLocation<bool>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                Workflow_TypedDataContext6_ForReadOnly valDataContext52 = new Workflow_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
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
                Workflow_TypedDataContext11_ForReadOnly valDataContext56 = new Workflow_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                Workflow_TypedDataContext11 refDataContext57 = new Workflow_TypedDataContext11(locations, true);
                return refDataContext57.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set);
            }
            if ((expressionId == 58)) {
                Workflow_TypedDataContext11_ForReadOnly valDataContext58 = new Workflow_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                Workflow_TypedDataContext11 refDataContext59 = new Workflow_TypedDataContext11(locations, true);
                return refDataContext59.GetLocation<string>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                Workflow_TypedDataContext11 refDataContext60 = new Workflow_TypedDataContext11(locations, true);
                return refDataContext60.GetLocation<string>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set);
            }
            if ((expressionId == 61)) {
                Workflow_TypedDataContext11 refDataContext61 = new Workflow_TypedDataContext11(locations, true);
                return refDataContext61.GetLocation<double>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                Workflow_TypedDataContext11_ForReadOnly valDataContext62 = new Workflow_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                Workflow_TypedDataContext11 refDataContext63 = new Workflow_TypedDataContext11(locations, true);
                return refDataContext63.GetLocation<string>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set);
            }
            if ((expressionId == 64)) {
                Workflow_TypedDataContext11 refDataContext64 = new Workflow_TypedDataContext11(locations, true);
                return refDataContext64.GetLocation<string>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set);
            }
            if ((expressionId == 65)) {
                Workflow_TypedDataContext11 refDataContext65 = new Workflow_TypedDataContext11(locations, true);
                return refDataContext65.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set);
            }
            if ((expressionId == 66)) {
                Workflow_TypedDataContext11 refDataContext66 = new Workflow_TypedDataContext11(locations, true);
                return refDataContext66.GetLocation<string>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set);
            }
            if ((expressionId == 67)) {
                Workflow_TypedDataContext11_ForReadOnly valDataContext67 = new Workflow_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                Workflow_TypedDataContext11_ForReadOnly valDataContext68 = new Workflow_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                Workflow_TypedDataContext11 refDataContext69 = new Workflow_TypedDataContext11(locations, true);
                return refDataContext69.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set);
            }
            if ((expressionId == 70)) {
                Workflow_TypedDataContext11_ForReadOnly valDataContext70 = new Workflow_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                Workflow_TypedDataContext11_ForReadOnly valDataContext71 = new Workflow_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                Workflow_TypedDataContext10_ForReadOnly valDataContext72 = new Workflow_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                Workflow_TypedDataContext10_ForReadOnly valDataContext73 = new Workflow_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                Workflow_TypedDataContext12_ForReadOnly valDataContext74 = new Workflow_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                Workflow_TypedDataContext12_ForReadOnly valDataContext75 = new Workflow_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                Workflow_TypedDataContext12 refDataContext76 = new Workflow_TypedDataContext12(locations, true);
                return refDataContext76.GetLocation<string>(refDataContext76.ValueType___Expr76Get, refDataContext76.ValueType___Expr76Set);
            }
            if ((expressionId == 77)) {
                Workflow_TypedDataContext15_ForReadOnly valDataContext77 = new Workflow_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                Workflow_TypedDataContext15 refDataContext78 = new Workflow_TypedDataContext15(locations, true);
                return refDataContext78.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set);
            }
            if ((expressionId == 79)) {
                Workflow_TypedDataContext15_ForReadOnly valDataContext79 = new Workflow_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext79.ValueType___Expr79Get();
            }
            if ((expressionId == 80)) {
                Workflow_TypedDataContext15 refDataContext80 = new Workflow_TypedDataContext15(locations, true);
                return refDataContext80.GetLocation<string>(refDataContext80.ValueType___Expr80Get, refDataContext80.ValueType___Expr80Set);
            }
            if ((expressionId == 81)) {
                Workflow_TypedDataContext15 refDataContext81 = new Workflow_TypedDataContext15(locations, true);
                return refDataContext81.GetLocation<string>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set);
            }
            if ((expressionId == 82)) {
                Workflow_TypedDataContext15 refDataContext82 = new Workflow_TypedDataContext15(locations, true);
                return refDataContext82.GetLocation<string>(refDataContext82.ValueType___Expr82Get, refDataContext82.ValueType___Expr82Set);
            }
            if ((expressionId == 83)) {
                Workflow_TypedDataContext15_ForReadOnly valDataContext83 = new Workflow_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                Workflow_TypedDataContext15 refDataContext84 = new Workflow_TypedDataContext15(locations, true);
                return refDataContext84.GetLocation<string>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set);
            }
            if ((expressionId == 85)) {
                Workflow_TypedDataContext15_ForReadOnly valDataContext85 = new Workflow_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                Workflow_TypedDataContext14_ForReadOnly valDataContext86 = new Workflow_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                Workflow_TypedDataContext14_ForReadOnly valDataContext87 = new Workflow_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                Workflow_TypedDataContext16_ForReadOnly valDataContext88 = new Workflow_TypedDataContext16_ForReadOnly(locations, true);
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                Workflow_TypedDataContext16_ForReadOnly valDataContext89 = new Workflow_TypedDataContext16_ForReadOnly(locations, true);
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                Workflow_TypedDataContext16 refDataContext90 = new Workflow_TypedDataContext16(locations, true);
                return refDataContext90.GetLocation<string>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set);
            }
            if ((expressionId == 91)) {
                Workflow_TypedDataContext17_ForReadOnly valDataContext91 = new Workflow_TypedDataContext17_ForReadOnly(locations, true);
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                Workflow_TypedDataContext18_ForReadOnly valDataContext92 = new Workflow_TypedDataContext18_ForReadOnly(locations, true);
                return valDataContext92.ValueType___Expr92Get();
            }
            if ((expressionId == 93)) {
                Workflow_TypedDataContext18_ForReadOnly valDataContext93 = new Workflow_TypedDataContext18_ForReadOnly(locations, true);
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                Workflow_TypedDataContext18_ForReadOnly valDataContext94 = new Workflow_TypedDataContext18_ForReadOnly(locations, true);
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                Workflow_TypedDataContext19_ForReadOnly valDataContext95 = new Workflow_TypedDataContext19_ForReadOnly(locations, true);
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                Workflow_TypedDataContext19 refDataContext96 = new Workflow_TypedDataContext19(locations, true);
                return refDataContext96.GetLocation<string>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set);
            }
            if ((expressionId == 97)) {
                Workflow_TypedDataContext19_ForReadOnly valDataContext97 = new Workflow_TypedDataContext19_ForReadOnly(locations, true);
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                Workflow_TypedDataContext19 refDataContext98 = new Workflow_TypedDataContext19(locations, true);
                return refDataContext98.GetLocation<string>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set);
            }
            if ((expressionId == 99)) {
                Workflow_TypedDataContext19 refDataContext99 = new Workflow_TypedDataContext19(locations, true);
                return refDataContext99.GetLocation<string>(refDataContext99.ValueType___Expr99Get, refDataContext99.ValueType___Expr99Set);
            }
            if ((expressionId == 100)) {
                Workflow_TypedDataContext19 refDataContext100 = new Workflow_TypedDataContext19(locations, true);
                return refDataContext100.GetLocation<string>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set);
            }
            if ((expressionId == 101)) {
                Workflow_TypedDataContext19_ForReadOnly valDataContext101 = new Workflow_TypedDataContext19_ForReadOnly(locations, true);
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                Workflow_TypedDataContext19 refDataContext102 = new Workflow_TypedDataContext19(locations, true);
                return refDataContext102.GetLocation<string>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set);
            }
            if ((expressionId == 103)) {
                Workflow_TypedDataContext19_ForReadOnly valDataContext103 = new Workflow_TypedDataContext19_ForReadOnly(locations, true);
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                Workflow_TypedDataContext19 refDataContext104 = new Workflow_TypedDataContext19(locations, true);
                return refDataContext104.GetLocation<string>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set);
            }
            if ((expressionId == 105)) {
                Workflow_TypedDataContext20_ForReadOnly valDataContext105 = new Workflow_TypedDataContext20_ForReadOnly(locations, true);
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                Workflow_TypedDataContext20 refDataContext106 = new Workflow_TypedDataContext20(locations, true);
                return refDataContext106.GetLocation<string>(refDataContext106.ValueType___Expr106Get, refDataContext106.ValueType___Expr106Set);
            }
            if ((expressionId == 107)) {
                Workflow_TypedDataContext20_ForReadOnly valDataContext107 = new Workflow_TypedDataContext20_ForReadOnly(locations, true);
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                Workflow_TypedDataContext20 refDataContext108 = new Workflow_TypedDataContext20(locations, true);
                return refDataContext108.GetLocation<string>(refDataContext108.ValueType___Expr108Get, refDataContext108.ValueType___Expr108Set);
            }
            if ((expressionId == 109)) {
                Workflow_TypedDataContext20 refDataContext109 = new Workflow_TypedDataContext20(locations, true);
                return refDataContext109.GetLocation<string>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set);
            }
            if ((expressionId == 110)) {
                Workflow_TypedDataContext20 refDataContext110 = new Workflow_TypedDataContext20(locations, true);
                return refDataContext110.GetLocation<string>(refDataContext110.ValueType___Expr110Get, refDataContext110.ValueType___Expr110Set);
            }
            if ((expressionId == 111)) {
                Workflow_TypedDataContext20_ForReadOnly valDataContext111 = new Workflow_TypedDataContext20_ForReadOnly(locations, true);
                return valDataContext111.ValueType___Expr111Get();
            }
            if ((expressionId == 112)) {
                Workflow_TypedDataContext20 refDataContext112 = new Workflow_TypedDataContext20(locations, true);
                return refDataContext112.GetLocation<string>(refDataContext112.ValueType___Expr112Get, refDataContext112.ValueType___Expr112Set);
            }
            if ((expressionId == 113)) {
                Workflow_TypedDataContext20_ForReadOnly valDataContext113 = new Workflow_TypedDataContext20_ForReadOnly(locations, true);
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                Workflow_TypedDataContext20 refDataContext114 = new Workflow_TypedDataContext20(locations, true);
                return refDataContext114.GetLocation<string>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set);
            }
            if ((expressionId == 115)) {
                Workflow_TypedDataContext21_ForReadOnly valDataContext115 = new Workflow_TypedDataContext21_ForReadOnly(locations, true);
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                Workflow_TypedDataContext21_ForReadOnly valDataContext116 = new Workflow_TypedDataContext21_ForReadOnly(locations, true);
                return valDataContext116.ValueType___Expr116Get();
            }
            if ((expressionId == 117)) {
                Workflow_TypedDataContext21_ForReadOnly valDataContext117 = new Workflow_TypedDataContext21_ForReadOnly(locations, true);
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                Workflow_TypedDataContext21_ForReadOnly valDataContext118 = new Workflow_TypedDataContext21_ForReadOnly(locations, true);
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                Workflow_TypedDataContext21_ForReadOnly valDataContext119 = new Workflow_TypedDataContext21_ForReadOnly(locations, true);
                return valDataContext119.ValueType___Expr119Get();
            }
            if ((expressionId == 120)) {
                Workflow_TypedDataContext22_ForReadOnly valDataContext120 = new Workflow_TypedDataContext22_ForReadOnly(locations, true);
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                Workflow_TypedDataContext22_ForReadOnly valDataContext121 = new Workflow_TypedDataContext22_ForReadOnly(locations, true);
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                Workflow_TypedDataContext22_ForReadOnly valDataContext122 = new Workflow_TypedDataContext22_ForReadOnly(locations, true);
                return valDataContext122.ValueType___Expr122Get();
            }
            if ((expressionId == 123)) {
                Workflow_TypedDataContext22_ForReadOnly valDataContext123 = new Workflow_TypedDataContext22_ForReadOnly(locations, true);
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                Workflow_TypedDataContext22_ForReadOnly valDataContext124 = new Workflow_TypedDataContext22_ForReadOnly(locations, true);
                return valDataContext124.ValueType___Expr124Get();
            }
            if ((expressionId == 125)) {
                Workflow_TypedDataContext23 refDataContext125 = new Workflow_TypedDataContext23(locations, true);
                return refDataContext125.GetLocation<string>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set);
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
                Workflow_TypedDataContext23_ForReadOnly valDataContext130 = new Workflow_TypedDataContext23_ForReadOnly(locations, true);
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                Workflow_TypedDataContext23_ForReadOnly valDataContext131 = new Workflow_TypedDataContext23_ForReadOnly(locations, true);
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                Workflow_TypedDataContext23_ForReadOnly valDataContext132 = new Workflow_TypedDataContext23_ForReadOnly(locations, true);
                return valDataContext132.ValueType___Expr132Get();
            }
            if ((expressionId == 133)) {
                Workflow_TypedDataContext23_ForReadOnly valDataContext133 = new Workflow_TypedDataContext23_ForReadOnly(locations, true);
                return valDataContext133.ValueType___Expr133Get();
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
                        && ((expressionText == "BodyManagerEmail + \"  \" + \"<a href=\'\" + CurrentUrl + \"?SPHostUrl=\" + CurrentHostU" +
                            "rl + \"&SPAppWebUrl=\" + CurrentAppUrl + \"&CaseView=0&CurItemId=\" + CurrentItemID " +
                            "+ \"&TaskUrl=%TaskSpecial: TaskUrl%\'>รายละเอียด</a><br/>\"") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BodyManagerEmail") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "outcome_0") 
                        && (Workflow_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TitleManagerEmail") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "OfficerManager") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TitleManagerEmail") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"แจ้งยกเลิกการขออนุมัติการลาของ \" + Title") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Output :\" + outcome_0.ToString()") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "outcome_0 == 0") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"new\") || RequestType.ToLower().Equals(\"1\")") 
                        && (Workflow_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext8.Validate(locations, true, 0) == true)))) {
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
                        && ((expressionText == "ApproveStatus") 
                        && (Workflow_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ApproveStatus") 
                        && (Workflow_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"new\")") 
                        && (Workflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
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
                        && ((expressionText == "ApproveStatus") 
                        && (Workflow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ExtraOwnApprove") 
                        && (Workflow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EmailToRequester") 
                        && (Workflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BodyRequesterEmail+ApproveStatus+ \" การขออนุมัติของท่าน \" + \"<a href=\'\" + Current" +
                            "Url + \"?SPHostUrl=\" + CurrentHostUrl + \"&SPAppWebUrl=\" + CurrentAppUrl + \"&CaseV" +
                            "iew=1&CurItemId=\" + CurrentItemID + \"\'>รายละเอียด</a><br/>\"") 
                        && (Workflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TitleRequesterEmail+ExtraOwnApprove") 
                        && (Workflow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iscompleteParallel") 
                        && (Workflow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Error In Send Task :\"+exception.ToString().Length") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "errorindex") 
                        && (Workflow_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "errormax") 
                        && (Workflow_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "exception.ToString().Length") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "errorlen") 
                        && (Workflow_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(errorlen-errorindex) > errormax") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "exception.ToString().Substring(errorindex,errormax)") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "exception.ToString().Substring(errorindex,(errorlen-errorindex))") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "errorindex+errormax") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "errorindex") 
                        && (Workflow_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "errorindex < exception.ToString().Length;") 
                        && (Workflow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iscancelstate") 
                        && (Workflow_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iscompleteParallel") 
                        && (Workflow_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iscompleteParallel") 
                        && (Workflow_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(RequestType.ToLower().Equals(\"new\") || RequestType.ToLower().Equals(\"1\")) && isc" +
                            "ancelstate == 0") 
                        && (Workflow_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(RequestType.ToLower().Equals(\"cancel\") || RequestType.ToLower().Equals(\"2\") )&& " +
                            "iscancelstate == 0") 
                        && (Workflow_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iscancelstate == 1") 
                        && (Workflow_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "listItemProps") 
                        && (Workflow_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeaveStatus") 
                        && (Workflow_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RequesterId") 
                        && (Workflow_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NumberOfDay") 
                        && (Workflow_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "listItemProps") 
                        && (Workflow_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeaveType") 
                        && (Workflow_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Title") 
                        && (Workflow_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dynamichr") 
                        && (Workflow_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "OfficerManager") 
                        && (Workflow_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dynamichr != null") 
                        && (Workflow_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dynamichr") 
                        && (Workflow_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "listHrApprove") 
                        && (Workflow_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dynamichr.ToString()") 
                        && (Workflow_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"RequesterId ID in Get Info : \" + RequesterId +\n\"\\r\\nManager ID in Get Info : \" +" +
                            "OfficerManager+\n\"\\r\\nHR ID in Get Info : \" + listHrApprove.Count") 
                        && (Workflow_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"new\") || RequestType.ToLower().Equals(\"1\")") 
                        && (Workflow_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"cancel\") || RequestType.ToLower().Equals(\"2\")") 
                        && (Workflow_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ApproveStatus") 
                        && (Workflow_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dv_0") 
                        && (Workflow_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentAppUrl") 
                        && (Workflow_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RequestType") 
                        && (Workflow_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentUrl") 
                        && (Workflow_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dv_0") 
                        && (Workflow_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentHostUrl") 
                        && (Workflow_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentUrl+\"\\r\\n\"+\nCurrentHostUrl + \"\\r\\n\"+\nCurrentAppUrl + \"\\r\\n\"") 
                        && (Workflow_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"new\") || RequestType.ToLower().Equals(\"1\")") 
                        && (Workflow_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"cancel\")|| RequestType.ToLower().Equals(\"2\")") 
                        && (Workflow_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext16_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ApproveStatus") 
                        && (Workflow_TypedDataContext16.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "listHrApprove.Count > 0 && ApproveStatus.Equals(\"Approved\")") 
                        && (Workflow_TypedDataContext17_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "listHrApprove") 
                        && (Workflow_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BodyHrEmail + ApproveStatus + \"  \" + \"<a href=\'\" + CurrentUrl + \"?SPHostUrl=\" + C" +
                            "urrentHostUrl + \"&SPAppWebUrl=\" + CurrentAppUrl + \"&CaseView=2&CurItemId=\" + Cur" +
                            "rentItemID + \"\'>รายละเอียด</a><br/>\"") 
                        && (Workflow_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TitleHREmail") 
                        && (Workflow_TypedDataContext18_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"แจ้งการขออนุมัติการลาของ \" + Title") 
                        && (Workflow_TypedDataContext19_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TitleManagerEmail") 
                        && (Workflow_TypedDataContext19.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"กรุณาพิจารณา การลา \" + LeaveType + \" ของ \" +Title") 
                        && (Workflow_TypedDataContext19_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BodyManagerEmail") 
                        && (Workflow_TypedDataContext19.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TitleRequesterEmail") 
                        && (Workflow_TypedDataContext19.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BodyRequesterEmail") 
                        && (Workflow_TypedDataContext19.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Review : แจ้งผลการขออนุมัติการลาของ \"+Title") 
                        && (Workflow_TypedDataContext19_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TitleHREmail") 
                        && (Workflow_TypedDataContext19.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"ตามที่ \"+ Title + \"ได้ขออนุมัติการลา \"+LeaveType+\" โดยมีผลการพิจารณา คือ \"") 
                        && (Workflow_TypedDataContext19_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BodyHrEmail") 
                        && (Workflow_TypedDataContext19.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"แจ้งการขออนุมัติยกเลิกการลาของ \" + Title") 
                        && (Workflow_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TitleManagerEmail") 
                        && (Workflow_TypedDataContext20.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"กรุณาพิจารณา ยกเลิกการลา \" + LeaveType + \" ของ \" + Title") 
                        && (Workflow_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BodyManagerEmail") 
                        && (Workflow_TypedDataContext20.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TitleRequesterEmail") 
                        && (Workflow_TypedDataContext20.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BodyRequesterEmail") 
                        && (Workflow_TypedDataContext20.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Review : แจ้งผลการขออนุมัติยกเลิกการลาของ \" + Title") 
                        && (Workflow_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TitleHREmail") 
                        && (Workflow_TypedDataContext20.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"ตามที่ \" + Title + \"ได้ขออนุมัติยกเลิกการลา \" + LeaveType + \" โดยมีผลการพิจารณา " +
                            "คือ \"") 
                        && (Workflow_TypedDataContext20_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BodyHrEmail") 
                        && (Workflow_TypedDataContext20.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Set Status to : \"+setStatusRequest") 
                        && (Workflow_TypedDataContext21_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext21_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 116;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext21_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 117;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext21_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 118;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext21_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 119;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Set Status to : \"+setStatusRequest") 
                        && (Workflow_TypedDataContext22_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 120;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext22_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 121;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext22_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 122;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext22_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 123;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext22_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 124;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext23.Validate(locations, true, 0) == true)))) {
                expressionId = 125;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Set Status to : \"+setStatusRequest") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 126;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestType.ToLower().Equals(\"new\")") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 127;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 128;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 129;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 130;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentListGUID") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 131;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentItemID") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 132;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "setStatusRequest") 
                        && (Workflow_TypedDataContext23_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 133;
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
                return new Workflow_TypedDataContext8(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Workflow_TypedDataContext8_ForReadOnly(locationReferences).@__Expr18GetTree();
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
                return new Workflow_TypedDataContext8(locationReferences).@__Expr25GetTree();
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
                return new Workflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new Workflow_TypedDataContext7(locationReferences).@__Expr31GetTree();
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
                return new Workflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new Workflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new Workflow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new Workflow_TypedDataContext7(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new Workflow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new Workflow_TypedDataContext9(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new Workflow_TypedDataContext9(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new Workflow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new Workflow_TypedDataContext9(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new Workflow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr44GetTree();
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
                return new Workflow_TypedDataContext9(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new Workflow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new Workflow_TypedDataContext6(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new Workflow_TypedDataContext6(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new Workflow_TypedDataContext6_ForReadOnly(locationReferences).@__Expr52GetTree();
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
                return new Workflow_TypedDataContext11_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new Workflow_TypedDataContext11(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new Workflow_TypedDataContext11_ForReadOnly(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new Workflow_TypedDataContext11(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new Workflow_TypedDataContext11(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new Workflow_TypedDataContext11(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new Workflow_TypedDataContext11_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new Workflow_TypedDataContext11(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new Workflow_TypedDataContext11(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new Workflow_TypedDataContext11(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new Workflow_TypedDataContext11(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new Workflow_TypedDataContext11_ForReadOnly(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new Workflow_TypedDataContext11_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new Workflow_TypedDataContext11(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new Workflow_TypedDataContext11_ForReadOnly(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new Workflow_TypedDataContext11_ForReadOnly(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new Workflow_TypedDataContext10_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new Workflow_TypedDataContext10_ForReadOnly(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new Workflow_TypedDataContext12_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new Workflow_TypedDataContext12_ForReadOnly(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new Workflow_TypedDataContext12(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new Workflow_TypedDataContext15_ForReadOnly(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new Workflow_TypedDataContext15(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new Workflow_TypedDataContext15_ForReadOnly(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new Workflow_TypedDataContext15(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new Workflow_TypedDataContext15(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new Workflow_TypedDataContext15(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new Workflow_TypedDataContext15_ForReadOnly(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new Workflow_TypedDataContext15(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new Workflow_TypedDataContext15_ForReadOnly(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new Workflow_TypedDataContext14_ForReadOnly(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new Workflow_TypedDataContext14_ForReadOnly(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new Workflow_TypedDataContext16_ForReadOnly(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new Workflow_TypedDataContext16_ForReadOnly(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new Workflow_TypedDataContext16(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new Workflow_TypedDataContext17_ForReadOnly(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new Workflow_TypedDataContext18_ForReadOnly(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new Workflow_TypedDataContext18_ForReadOnly(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new Workflow_TypedDataContext18_ForReadOnly(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new Workflow_TypedDataContext19_ForReadOnly(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new Workflow_TypedDataContext19(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new Workflow_TypedDataContext19_ForReadOnly(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new Workflow_TypedDataContext19(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new Workflow_TypedDataContext19(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new Workflow_TypedDataContext19(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new Workflow_TypedDataContext19_ForReadOnly(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new Workflow_TypedDataContext19(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new Workflow_TypedDataContext19_ForReadOnly(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new Workflow_TypedDataContext19(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new Workflow_TypedDataContext20_ForReadOnly(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new Workflow_TypedDataContext20(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new Workflow_TypedDataContext20_ForReadOnly(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new Workflow_TypedDataContext20(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new Workflow_TypedDataContext20(locationReferences).@__Expr109GetTree();
            }
            if ((expressionId == 110)) {
                return new Workflow_TypedDataContext20(locationReferences).@__Expr110GetTree();
            }
            if ((expressionId == 111)) {
                return new Workflow_TypedDataContext20_ForReadOnly(locationReferences).@__Expr111GetTree();
            }
            if ((expressionId == 112)) {
                return new Workflow_TypedDataContext20(locationReferences).@__Expr112GetTree();
            }
            if ((expressionId == 113)) {
                return new Workflow_TypedDataContext20_ForReadOnly(locationReferences).@__Expr113GetTree();
            }
            if ((expressionId == 114)) {
                return new Workflow_TypedDataContext20(locationReferences).@__Expr114GetTree();
            }
            if ((expressionId == 115)) {
                return new Workflow_TypedDataContext21_ForReadOnly(locationReferences).@__Expr115GetTree();
            }
            if ((expressionId == 116)) {
                return new Workflow_TypedDataContext21_ForReadOnly(locationReferences).@__Expr116GetTree();
            }
            if ((expressionId == 117)) {
                return new Workflow_TypedDataContext21_ForReadOnly(locationReferences).@__Expr117GetTree();
            }
            if ((expressionId == 118)) {
                return new Workflow_TypedDataContext21_ForReadOnly(locationReferences).@__Expr118GetTree();
            }
            if ((expressionId == 119)) {
                return new Workflow_TypedDataContext21_ForReadOnly(locationReferences).@__Expr119GetTree();
            }
            if ((expressionId == 120)) {
                return new Workflow_TypedDataContext22_ForReadOnly(locationReferences).@__Expr120GetTree();
            }
            if ((expressionId == 121)) {
                return new Workflow_TypedDataContext22_ForReadOnly(locationReferences).@__Expr121GetTree();
            }
            if ((expressionId == 122)) {
                return new Workflow_TypedDataContext22_ForReadOnly(locationReferences).@__Expr122GetTree();
            }
            if ((expressionId == 123)) {
                return new Workflow_TypedDataContext22_ForReadOnly(locationReferences).@__Expr123GetTree();
            }
            if ((expressionId == 124)) {
                return new Workflow_TypedDataContext22_ForReadOnly(locationReferences).@__Expr124GetTree();
            }
            if ((expressionId == 125)) {
                return new Workflow_TypedDataContext23(locationReferences).@__Expr125GetTree();
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
                return new Workflow_TypedDataContext23_ForReadOnly(locationReferences).@__Expr130GetTree();
            }
            if ((expressionId == 131)) {
                return new Workflow_TypedDataContext23_ForReadOnly(locationReferences).@__Expr131GetTree();
            }
            if ((expressionId == 132)) {
                return new Workflow_TypedDataContext23_ForReadOnly(locationReferences).@__Expr132GetTree();
            }
            if ((expressionId == 133)) {
                return new Workflow_TypedDataContext23_ForReadOnly(locationReferences).@__Expr133GetTree();
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
                
                #line 65 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      CurrentSiteUrl;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 65 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 65 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 72 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr1Get() {
                
                #line 72 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 72 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 79 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      CurrentListID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 79 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 79 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 86 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      currentListName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 86 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 86 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 93 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                      CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr5Get() {
                
                #line 93 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 93 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 98 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                      new Guid(CurrentListID);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr4Get() {
                
                #line 98 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 105 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      "List : "+CurrentListID+"\r\n"+
"ItemID : "+CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr6Get() {
                
                #line 105 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 420 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                          iscancelstate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr7Get() {
                
                #line 420 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 420 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 430 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                          iscompleteParallel;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 430 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 430 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                          iscompleteParallel = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 862 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                  iscancelstate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr50Get() {
                
                #line 862 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                  iscancelstate;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr50Set(int value) {
                
                #line 862 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                  iscancelstate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr50Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr50Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 872 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                  iscompleteParallel;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr51Get() {
                
                #line 872 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                  iscompleteParallel;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(bool value) {
                
                #line 872 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                  iscompleteParallel = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
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
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 439 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                        iscompleteParallel;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr52Get() {
                
                #line 439 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                        iscompleteParallel;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 888 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      (RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1")) && iscancelstate == 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr53Get() {
                
                #line 888 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                      (RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1")) && iscancelstate == 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 998 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      (RequestType.ToLower().Equals("cancel") || RequestType.ToLower().Equals("2") )&& iscancelstate == 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr54Get() {
                
                #line 998 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                      (RequestType.ToLower().Equals("cancel") || RequestType.ToLower().Equals("2") )&& iscancelstate == 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 1057 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      iscancelstate == 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr55Get() {
                
                #line 1057 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                      iscancelstate == 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
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
                
                #line 465 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                                                                      EmailToRequester;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr11Get() {
                
                #line 465 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 465 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                      EmailToRequester = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(System.Collections.ObjectModel.Collection<string> value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 664 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                  setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr31Get() {
                
                #line 664 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                                  setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(string value) {
                
                #line 664 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                                  setStatusRequest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 678 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                  setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr32Get() {
                
                #line 678 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 678 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 691 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            ApproveStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr33Get() {
                
                #line 691 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                            ApproveStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(string value) {
                
                #line 691 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                            ApproveStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 701 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            ExtraOwnApprove;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr34Get() {
                
                #line 701 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                            ExtraOwnApprove;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(string value) {
                
                #line 701 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                            ExtraOwnApprove = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 731 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      iscompleteParallel;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr38Get() {
                
                #line 731 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                      iscompleteParallel;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr38Set(bool value) {
                
                #line 731 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                      iscompleteParallel = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr38Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr38Set(value);
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
                
                #line 454 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 454 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 470 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      RequesterId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr10Get() {
                
                #line 470 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 477 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      !string.IsNullOrEmpty(OfficerManager);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 477 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                      !string.IsNullOrEmpty(OfficerManager);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 656 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                            RequestType.ToLower().Equals("new");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr30Get() {
                
                #line 656 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                            RequestType.ToLower().Equals("new");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 724 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                                                                      EmailToRequester;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr35Get() {
                
                #line 724 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                      EmailToRequester;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 714 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      BodyRequesterEmail+ApproveStatus+ " การขออนุมัติของท่าน " + "<a href='" + CurrentUrl + "?SPHostUrl=" + CurrentHostUrl + "&SPAppWebUrl=" + CurrentAppUrl + "&CaseView=1&CurItemId=" + CurrentItemID + "'>รายละเอียด</a><br/>";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr36Get() {
                
                #line 714 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                      BodyRequesterEmail+ApproveStatus+ " การขออนุมัติของท่าน " + "<a href='" + CurrentUrl + "?SPHostUrl=" + CurrentHostUrl + "&SPAppWebUrl=" + CurrentAppUrl + "&CaseView=1&CurItemId=" + CurrentItemID + "'>รายละเอียด</a><br/>";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 719 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      TitleRequesterEmail+ExtraOwnApprove;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr37Get() {
                
                #line 719 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                      TitleRequesterEmail+ExtraOwnApprove;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
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
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 529 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                            outcome_0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr17Get() {
                
                #line 529 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                            outcome_0;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(int value) {
                
                #line 529 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                            outcome_0 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 586 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                          setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr25Get() {
                
                #line 586 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                                          setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(string value) {
                
                #line 586 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                                          setStatusRequest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 600 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                          setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr26Get() {
                
                #line 600 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 600 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 613 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                    ApproveStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr27Get() {
                
                #line 613 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                                    ApproveStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(string value) {
                
                #line 613 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                                    ApproveStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 627 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                    setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr28Get() {
                
                #line 627 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                                    setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(string value) {
                
                #line 627 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                                    setStatusRequest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 637 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                    ApproveStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 637 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                                    ApproveStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(string value) {
                
                #line 637 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                                    ApproveStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
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
                
                #line 490 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            TitleManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 490 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 497 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            BodyManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 497 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 509 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            BodyManagerEmail + "  " + "<a href='" + CurrentUrl + "?SPHostUrl=" + CurrentHostUrl + "&SPAppWebUrl=" + CurrentAppUrl + "&CaseView=0&CurItemId=" + CurrentItemID + "&TaskUrl=%TaskSpecial: TaskUrl%'>รายละเอียด</a><br/>";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 509 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                            BodyManagerEmail + "  " + "<a href='" + CurrentUrl + "?SPHostUrl=" + CurrentHostUrl + "&SPAppWebUrl=" + CurrentAppUrl + "&CaseView=0&CurItemId=" + CurrentItemID + "&TaskUrl=%TaskSpecial: TaskUrl%'>รายละเอียด</a><br/>";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 519 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            BodyManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 519 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                            BodyManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 555 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            TitleManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr18Get() {
                
                #line 555 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                            TitleManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 504 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            OfficerManager;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 504 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                            OfficerManager;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 514 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            TitleManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr20Get() {
                
                #line 514 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                            TitleManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 524 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            "แจ้งยกเลิกการขออนุมัติการลาของ " + Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr21Get() {
                
                #line 524 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                            "แจ้งยกเลิกการขออนุมัติการลาของ " + Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 562 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            "Output :" + outcome_0.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr22Get() {
                
                #line 562 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                            "Output :" + outcome_0.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 570 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              outcome_0 == 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr23Get() {
                
                #line 570 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                              outcome_0 == 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 578 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                    RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr24Get() {
                
                #line 578 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                                    RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
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
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 759 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      errorindex;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr40Get() {
                
                #line 759 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                      errorindex;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr40Set(int value) {
                
                #line 759 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                      errorindex = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr40Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr40Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 769 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      errormax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr41Get() {
                
                #line 769 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                      errormax;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr41Set(int value) {
                
                #line 769 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                      errormax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr41Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr41Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 779 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      errorlen;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr43Get() {
                
                #line 779 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                      errorlen;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(int value) {
                
                #line 779 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                      errorlen = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 821 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          errorindex;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr48Get() {
                
                #line 821 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                          errorindex;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr48Set(int value) {
                
                #line 821 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                          errorindex = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr48Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr48Set(value);
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
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 752 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      "Error In Send Task :"+exception.ToString().Length;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr39Get() {
                
                #line 752 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                      "Error In Send Task :"+exception.ToString().Length;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 784 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      exception.ToString().Length;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr42Get() {
                
                #line 784 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                      exception.ToString().Length;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 796 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                          (errorlen-errorindex) > errormax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr44Get() {
                
                #line 796 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                          (errorlen-errorindex) > errormax;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 803 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                              exception.ToString().Substring(errorindex,errormax);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr45Get() {
                
                #line 803 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                              exception.ToString().Substring(errorindex,errormax);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 812 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                              exception.ToString().Substring(errorindex,(errorlen-errorindex));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr46Get() {
                
                #line 812 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                              exception.ToString().Substring(errorindex,(errorlen-errorindex));
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 826 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          errorindex+errormax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr47Get() {
                
                #line 826 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                          errorindex+errormax;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 790 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                    errorindex < exception.ToString().Length;;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr49Get() {
                
                #line 790 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                    errorindex < exception.ToString().Length;;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
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
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 329 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr72Get() {
                
                #line 329 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                      RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 1186 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      RequestType.ToLower().Equals("cancel") || RequestType.ToLower().Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr73Get() {
                
                #line 1186 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                      RequestType.ToLower().Equals("cancel") || RequestType.ToLower().Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
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
            
            protected Microsoft.Activities.DynamicValue listItemProps {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((25 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((25 + locationsOffset), value);
                }
            }
            
            protected System.Collections.ObjectModel.Collection<int> testCollectionInt {
                get {
                    return ((System.Collections.ObjectModel.Collection<int>)(this.GetVariableValue((26 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((26 + locationsOffset), value);
                }
            }
            
            protected string hrarray {
                get {
                    return ((string)(this.GetVariableValue((27 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((27 + locationsOffset), value);
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
                
                #line 249 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                                              listItemProps;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr57Get() {
                
                #line 249 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              listItemProps;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr57Set(Microsoft.Activities.DynamicValue value) {
                
                #line 249 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                              listItemProps = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr57Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr57Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 276 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              LeaveStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr59Get() {
                
                #line 276 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              LeaveStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(string value) {
                
                #line 276 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                              LeaveStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 279 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              RequesterId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr60Get() {
                
                #line 279 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              RequesterId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr60Set(string value) {
                
                #line 279 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                              RequesterId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr60Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr60Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 273 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                              NumberOfDay;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr61Get() {
                
                #line 273 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              NumberOfDay;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(double value) {
                
                #line 273 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                              NumberOfDay = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 270 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              LeaveType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr63Get() {
                
                #line 270 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              LeaveType;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr63Set(string value) {
                
                #line 270 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                              LeaveType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr63Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr63Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 267 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr64Get() {
                
                #line 267 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr64Set(string value) {
                
                #line 267 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                              Title = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr64Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr64Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 264 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                                              dynamichr;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr65Get() {
                
                #line 264 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              dynamichr;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr65Set(Microsoft.Activities.DynamicValue value) {
                
                #line 264 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                              dynamichr = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr65Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr65Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 261 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              OfficerManager;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr66Get() {
                
                #line 261 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              OfficerManager;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr66Set(string value) {
                
                #line 261 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                              OfficerManager = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr66Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr66Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 299 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                                                    listHrApprove;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr69Get() {
                
                #line 299 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    listHrApprove;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr69Set(System.Collections.ObjectModel.Collection<string> value) {
                
                #line 299 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                    listHrApprove = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr69Set(System.Collections.ObjectModel.Collection<string> value) {
                this.GetValueTypeValues();
                this.@__Expr69Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 28))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 28);
                }
                expectedLocationsCount = 28;
                if (((locationReferences[(offset + 25)].Name != "listItemProps") 
                            || (locationReferences[(offset + 25)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 26)].Name != "testCollectionInt") 
                            || (locationReferences[(offset + 26)].Type != typeof(System.Collections.ObjectModel.Collection<int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 27)].Name != "hrarray") 
                            || (locationReferences[(offset + 27)].Type != typeof(string)))) {
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
            
            protected Microsoft.Activities.DynamicValue listItemProps {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((25 + locationsOffset))));
                }
            }
            
            protected System.Collections.ObjectModel.Collection<int> testCollectionInt {
                get {
                    return ((System.Collections.ObjectModel.Collection<int>)(this.GetVariableValue((26 + locationsOffset))));
                }
            }
            
            protected string hrarray {
                get {
                    return ((string)(this.GetVariableValue((27 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 244 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                              CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr56Get() {
                
                #line 244 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 239 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr58Get() {
                
                #line 239 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 256 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                                              listItemProps;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr62Get() {
                
                #line 256 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              listItemProps;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 286 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              dynamichr != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr67Get() {
                
                #line 286 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              dynamichr != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 294 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                                                    dynamichr;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr68Get() {
                
                #line 294 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    dynamichr;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 306 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    dynamichr.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr70Get() {
                
                #line 306 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    dynamichr.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 316 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              "RequesterId ID in Get Info : " + RequesterId +
"\r\nManager ID in Get Info : " +OfficerManager+
"\r\nHR ID in Get Info : " + listHrApprove.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr71Get() {
                
                #line 316 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                              "RequesterId ID in Get Info : " + RequesterId +
"\r\nManager ID in Get Info : " +OfficerManager+
"\r\nHR ID in Get Info : " + listHrApprove.Count;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 28))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 28);
                }
                expectedLocationsCount = 28;
                if (((locationReferences[(offset + 25)].Name != "listItemProps") 
                            || (locationReferences[(offset + 25)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 26)].Name != "testCollectionInt") 
                            || (locationReferences[(offset + 26)].Type != typeof(System.Collections.ObjectModel.Collection<int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 27)].Name != "hrarray") 
                            || (locationReferences[(offset + 27)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext10_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext12 : Workflow_TypedDataContext2 {
            
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
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 213 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  ApproveStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr76Get() {
                
                #line 213 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                  ApproveStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr76Set(string value) {
                
                #line 213 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                  ApproveStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr76Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr76Set(value);
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
        private class Workflow_TypedDataContext12_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
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
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 193 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                        CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr74Get() {
                
                #line 193 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                        CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 188 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr75Get() {
                
                #line 188 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                        CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
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
        private class Workflow_TypedDataContext13 : Workflow_TypedDataContext2 {
            
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
        private class Workflow_TypedDataContext13_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
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
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 175 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr86Get() {
                
                #line 175 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                      RequestType.ToLower().Equals("new") || RequestType.ToLower().Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 1284 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      RequestType.ToLower().Equals("cancel")|| RequestType.ToLower().Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr87Get() {
                
                #line 1284 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                      RequestType.ToLower().Equals("cancel")|| RequestType.ToLower().Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
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
        private class Workflow_TypedDataContext15 : Workflow_TypedDataContext14 {
            
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
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 136 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                          dv_0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr78Get() {
                
                #line 136 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                          dv_0;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr78Set(Microsoft.Activities.DynamicValue value) {
                
                #line 136 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                          dv_0 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr78Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr78Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 151 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          CurrentAppUrl;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr80Get() {
                
                #line 151 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                          CurrentAppUrl;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr80Set(string value) {
                
                #line 151 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                          CurrentAppUrl = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr80Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr80Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 148 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          RequestType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr81Get() {
                
                #line 148 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                          RequestType;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr81Set(string value) {
                
                #line 148 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                          RequestType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr81Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr81Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 157 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          CurrentUrl;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr82Get() {
                
                #line 157 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                          CurrentUrl;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr82Set(string value) {
                
                #line 157 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                          CurrentUrl = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr82Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr82Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 154 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          CurrentHostUrl;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr84Get() {
                
                #line 154 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                          CurrentHostUrl;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr84Set(string value) {
                
                #line 154 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                          CurrentHostUrl = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr84Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr84Set(value);
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
                return Workflow_TypedDataContext14.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext15_ForReadOnly : Workflow_TypedDataContext14_ForReadOnly {
            
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
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 131 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                          CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr77Get() {
                
                #line 131 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                          CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 126 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                          CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr79Get() {
                
                #line 126 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                          CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 143 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                          dv_0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr83Get() {
                
                #line 143 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                          dv_0;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 164 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          CurrentUrl+"\r\n"+
CurrentHostUrl + "\r\n"+
CurrentAppUrl + "\r\n";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr85Get() {
                
                #line 164 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                          CurrentUrl+"\r\n"+
CurrentHostUrl + "\r\n"+
CurrentAppUrl + "\r\n";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
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
                return Workflow_TypedDataContext14_ForReadOnly.Validate(locationReferences, false, offset);
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
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 1322 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  ApproveStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr90Get() {
                
                #line 1322 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                  ApproveStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr90Set(string value) {
                
                #line 1322 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                  ApproveStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr90Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr90Set(value);
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
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 1302 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                        CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr88Get() {
                
                #line 1302 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                        CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 1297 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr89Get() {
                
                #line 1297 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                        CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
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
        private class Workflow_TypedDataContext17 : Workflow_TypedDataContext2 {
            
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
        private class Workflow_TypedDataContext17_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
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
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 948 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                          listHrApprove.Count > 0 && ApproveStatus.Equals("Approved");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr91Get() {
                
                #line 948 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                          listHrApprove.Count > 0 && ApproveStatus.Equals("Approved");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
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
        private class Workflow_TypedDataContext18 : Workflow_TypedDataContext17 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int outcom_hr;
            
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
                return Workflow_TypedDataContext17.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext18_ForReadOnly : Workflow_TypedDataContext17_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int outcom_hr;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 969 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                                                                                listHrApprove;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr92Get() {
                
                #line 969 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                                listHrApprove;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 959 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                BodyHrEmail + ApproveStatus + "  " + "<a href='" + CurrentUrl + "?SPHostUrl=" + CurrentHostUrl + "&SPAppWebUrl=" + CurrentAppUrl + "&CaseView=2&CurItemId=" + CurrentItemID + "'>รายละเอียด</a><br/>";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr93Get() {
                
                #line 959 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                                BodyHrEmail + ApproveStatus + "  " + "<a href='" + CurrentUrl + "?SPHostUrl=" + CurrentHostUrl + "&SPAppWebUrl=" + CurrentAppUrl + "&CaseView=2&CurItemId=" + CurrentItemID + "'>รายละเอียด</a><br/>";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr94GetTree() {
                
                #line 964 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                TitleHREmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr94Get() {
                
                #line 964 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                                TitleHREmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
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
                return Workflow_TypedDataContext17_ForReadOnly.Validate(locationReferences, false, offset);
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
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 339 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    TitleManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr96Get() {
                
                #line 339 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    TitleManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr96Set(string value) {
                
                #line 339 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                    TitleManagerEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr96Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr96Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 351 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    BodyManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr98Get() {
                
                #line 351 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    BodyManagerEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr98Set(string value) {
                
                #line 351 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                    BodyManagerEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr98Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr98Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 365 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    TitleRequesterEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr99Get() {
                
                #line 365 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    TitleRequesterEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr99Set(string value) {
                
                #line 365 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                    TitleRequesterEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr99Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr99Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 375 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    BodyRequesterEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr100Get() {
                
                #line 375 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    BodyRequesterEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr100Set(string value) {
                
                #line 375 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                    BodyRequesterEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr100Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr100Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 387 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    TitleHREmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr102Get() {
                
                #line 387 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    TitleHREmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr102Set(string value) {
                
                #line 387 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                    TitleHREmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr102Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr102Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 399 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    BodyHrEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr104Get() {
                
                #line 399 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    BodyHrEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr104Set(string value) {
                
                #line 399 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                    BodyHrEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr104Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr104Set(value);
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
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 344 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "แจ้งการขออนุมัติการลาของ " + Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr95Get() {
                
                #line 344 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    "แจ้งการขออนุมัติการลาของ " + Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 356 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "กรุณาพิจารณา การลา " + LeaveType + " ของ " +Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr97Get() {
                
                #line 356 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    "กรุณาพิจารณา การลา " + LeaveType + " ของ " +Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 392 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Review : แจ้งผลการขออนุมัติการลาของ "+Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr101Get() {
                
                #line 392 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    "Review : แจ้งผลการขออนุมัติการลาของ "+Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 404 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "ตามที่ "+ Title + "ได้ขออนุมัติการลา "+LeaveType+" โดยมีผลการพิจารณา คือ ";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr103Get() {
                
                #line 404 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    "ตามที่ "+ Title + "ได้ขออนุมัติการลา "+LeaveType+" โดยมีผลการพิจารณา คือ ";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
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
        private class Workflow_TypedDataContext20 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 1196 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    TitleManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr106Get() {
                
                #line 1196 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 1196 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 1208 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    BodyManagerEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr108Get() {
                
                #line 1208 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 1208 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 1222 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    TitleRequesterEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr109Get() {
                
                #line 1222 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 1222 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 1232 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    BodyRequesterEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr110Get() {
                
                #line 1232 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 1232 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 1244 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    TitleHREmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr112Get() {
                
                #line 1244 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 1244 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
                
                #line 1256 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    BodyHrEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr114Get() {
                
                #line 1256 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
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
                
                #line 1256 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
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
        private class Workflow_TypedDataContext20_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 1201 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "แจ้งการขออนุมัติยกเลิกการลาของ " + Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr105Get() {
                
                #line 1201 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    "แจ้งการขออนุมัติยกเลิกการลาของ " + Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 1213 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "กรุณาพิจารณา ยกเลิกการลา " + LeaveType + " ของ " + Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr107Get() {
                
                #line 1213 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    "กรุณาพิจารณา ยกเลิกการลา " + LeaveType + " ของ " + Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr111GetTree() {
                
                #line 1249 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Review : แจ้งผลการขออนุมัติยกเลิกการลาของ " + Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr111Get() {
                
                #line 1249 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    "Review : แจ้งผลการขออนุมัติยกเลิกการลาของ " + Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr111Get() {
                this.GetValueTypeValues();
                return this.@__Expr111Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 1261 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "ตามที่ " + Title + "ได้ขออนุมัติยกเลิกการลา " + LeaveType + " โดยมีผลการพิจารณา คือ ";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr113Get() {
                
                #line 1261 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                    "ตามที่ " + Title + "ได้ขออนุมัติยกเลิกการลา " + LeaveType + " โดยมีผลการพิจารณา คือ ";
                
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
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 1010 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        "Set Status to : "+setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr115Get() {
                
                #line 1010 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                        "Set Status to : "+setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr116GetTree() {
                
                #line 1030 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                              setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr116Get() {
                
                #line 1030 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                              setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr116Get() {
                this.GetValueTypeValues();
                return this.@__Expr116Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr117GetTree() {
                
                #line 1022 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                                                        CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr117Get() {
                
                #line 1022 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                        CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr117Get() {
                this.GetValueTypeValues();
                return this.@__Expr117Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr118GetTree() {
                
                #line 1017 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                        CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr118Get() {
                
                #line 1017 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                        CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr118Get() {
                this.GetValueTypeValues();
                return this.@__Expr118Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr119GetTree() {
                
                #line 1040 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr119Get() {
                
                #line 1040 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                        setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr119Get() {
                this.GetValueTypeValues();
                return this.@__Expr119Get();
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
            
            internal System.Linq.Expressions.Expression @__Expr120GetTree() {
                
                #line 900 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        "Set Status to : "+setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr120Get() {
                
                #line 900 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                        "Set Status to : "+setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr120Get() {
                this.GetValueTypeValues();
                return this.@__Expr120Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr121GetTree() {
                
                #line 920 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                              setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr121Get() {
                
                #line 920 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                              setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr121Get() {
                this.GetValueTypeValues();
                return this.@__Expr121Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr122GetTree() {
                
                #line 912 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                                                        CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr122Get() {
                
                #line 912 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                        CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr122Get() {
                this.GetValueTypeValues();
                return this.@__Expr122Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr123GetTree() {
                
                #line 907 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                        CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr123Get() {
                
                #line 907 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                        CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr123Get() {
                this.GetValueTypeValues();
                return this.@__Expr123Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr124GetTree() {
                
                #line 930 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr124Get() {
                
                #line 930 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                        setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr124Get() {
                this.GetValueTypeValues();
                return this.@__Expr124Get();
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
            
            internal System.Linq.Expressions.Expression @__Expr125GetTree() {
                
                #line 1069 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr125Get() {
                
                #line 1069 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                        setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr125Get() {
                this.GetValueTypeValues();
                return this.@__Expr125Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr125Set(string value) {
                
                #line 1069 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                
                                                                        setStatusRequest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr125Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr125Set(value);
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
            
            internal System.Linq.Expressions.Expression @__Expr126GetTree() {
                
                #line 1080 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          "Set Status to : "+setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr126Get() {
                
                #line 1080 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                          "Set Status to : "+setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr126Get() {
                this.GetValueTypeValues();
                return this.@__Expr126Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr127GetTree() {
                
                #line 1087 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                          RequestType.ToLower().Equals("new");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr127Get() {
                
                #line 1087 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                          RequestType.ToLower().Equals("new");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr127Get() {
                this.GetValueTypeValues();
                return this.@__Expr127Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr128GetTree() {
                
                #line 1107 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                    setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr128Get() {
                
                #line 1107 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                                    setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr128Get() {
                this.GetValueTypeValues();
                return this.@__Expr128Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr129GetTree() {
                
                #line 1099 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                                                              CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr129Get() {
                
                #line 1099 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                              CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr129Get() {
                this.GetValueTypeValues();
                return this.@__Expr129Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr130GetTree() {
                
                #line 1094 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr130Get() {
                
                #line 1094 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                              CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr130Get() {
                this.GetValueTypeValues();
                return this.@__Expr130Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr131GetTree() {
                
                #line 1130 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                                                              CurrentListGUID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr131Get() {
                
                #line 1130 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                              CurrentListGUID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr131Get() {
                this.GetValueTypeValues();
                return this.@__Expr131Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr132GetTree() {
                
                #line 1125 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              CurrentItemID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr132Get() {
                
                #line 1125 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                              CurrentItemID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr132Get() {
                this.GetValueTypeValues();
                return this.@__Expr132Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr133GetTree() {
                
                #line 1153 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          setStatusRequest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr133Get() {
                
                #line 1153 "E:\WORKSPACE\TORA-ASIA\LEAVEREQUEST\REPO\LEAVEREQUEST-DEMO\TORA-ASIA.LEAVEREQUEST\WORKFLOWS\LEAVEREQEUSTWF\WORKFLOW.XAML"
                return 
                                                                          setStatusRequest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr133Get() {
                this.GetValueTypeValues();
                return this.@__Expr133Get();
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
