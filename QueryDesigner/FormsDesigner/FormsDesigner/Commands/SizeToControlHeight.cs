﻿namespace FormsDesigner.Commands
{
    using System.ComponentModel.Design;

    public class SizeToControlHeight : AbstractFormsDesignerCommand
    {
        public override System.ComponentModel.Design.CommandID CommandID
        {
            get
            {
                return StandardCommands.SizeToControlHeight;
            }
        }
    }
}

