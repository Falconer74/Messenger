using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Desktop.Classes
{
    /// <summary>
    /// This interface describes the main work of the preview of the dialogue in the list of dialogues
    /// </summary>
    public interface ConversationPreviewItem
    {
        ///Automatically set preview values if there are necessary and valid data in the entity of the dialogue
        void InitializePreview();

        ///Name of conversation on preview
        string Name { get; set; }

        ///Text of last message on preview
        string Text { get; set; }

        ///Image of interlocutor (or group) on preview
        int Image { get; set; }

        ///Time of last message in conversation on preview
        string Time { get; set; }

        ///Amount of unread messages in conversation on preview
        int Unread { get; set; }
    }
}
