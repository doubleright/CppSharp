using System;
using System.Collections.Generic;
using CppSharp.AST;

namespace CppSharp.Generators
{
    public abstract class CodeTemplate : BlockGenerator, IDeclVisitor<bool>
    {
        public BindingContext Context { get; private set; }

        public DriverOptions Options { get { return Context.Options; } }

        public List<TranslationUnit> TranslationUnits { get; private set; }

        public TranslationUnit TranslationUnit { get { return TranslationUnits[0]; } }

        public abstract string FileExtension { get; }

        protected CodeTemplate(BindingContext context, TranslationUnit unit)
            : this(context, new List<TranslationUnit> { unit })
        {
        }

        protected CodeTemplate(BindingContext context, IEnumerable<TranslationUnit> units)
        {
            Context = context;
            TranslationUnits = new List<TranslationUnit>(units);
        }

        public abstract void Process();

        public new string Generate()
        {
            if (Options.IsCSharpGenerator && Options.CompileCode)
                return base.GenerateUnformatted();

            return base.Generate();
        }

        #region Visitor methods

        public bool VisitDeclaration(Declaration decl)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitClassDecl(Class @class)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitFieldDecl(Field field)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitFunctionDecl(Function function)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitMethodDecl(Method method)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitParameterDecl(Parameter parameter)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitTypedefDecl(TypedefDecl typedef)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitTypeAliasDecl(TypeAlias typeAlias)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitEnumDecl(Enumeration @enum)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitEnumItemDecl(Enumeration.Item item)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitVariableDecl(Variable variable)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitMacroDefinition(MacroDefinition macro)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitNamespace(Namespace @namespace)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitEvent(Event @event)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitProperty(Property property)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitFriend(Friend friend)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitClassTemplateDecl(ClassTemplate template)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitClassTemplateSpecializationDecl(ClassTemplateSpecialization specialization)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitFunctionTemplateDecl(FunctionTemplate template)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitFunctionTemplateSpecializationDecl(FunctionTemplateSpecialization specialization)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitVarTemplateDecl(VarTemplate template)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitVarTemplateSpecializationDecl(VarTemplateSpecialization template)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitTemplateTemplateParameterDecl(TemplateTemplateParameter templateTemplateParameter)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitTemplateParameterDecl(TypeTemplateParameter templateParameter)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitNonTypeTemplateParameterDecl(NonTypeTemplateParameter nonTypeTemplateParameter)
        {
            throw new NotImplementedException();
        }

        public virtual bool VisitTypeAliasTemplateDecl(TypeAliasTemplate typeAliasTemplate)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}