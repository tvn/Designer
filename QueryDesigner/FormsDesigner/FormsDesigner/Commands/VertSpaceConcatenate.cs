﻿namespace FormsDesigner.Commands
{
    using System.ComponentModel.Design;

    public class VertSpaceConcatenate : AbstractFormsDesignerCommand
    {
        public override System.ComponentModel.Design.CommandID CommandID
        {
            get
            {
                return StandardCommands.VertSpaceConcatenate;
            }
        }
    }
}

