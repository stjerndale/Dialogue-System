using System;
using UnityEngine;

namespace DS.Data
{
    using DS.ScriptableObjects;

    [Serializable]
    public class DSDialogueChoiceData
    {
        [field: SerializeField]
        public string Text { get; set; }

        [field: SerializeField]
        public DSDialogueSO NextDialogue { get; set; }
    }

}
