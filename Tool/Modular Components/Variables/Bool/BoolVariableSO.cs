using UnityEngine;

namespace DialogueEditor.ModularComponents
{
    public class BoolVariableSO : ScriptableObject
    {
#if UNITY_EDITOR
#pragma warning disable CS0414
        [Multiline]
        [SerializeField] private string _developerDescription = "";
#pragma warning restore CS0414
#endif
        [SerializeField] private bool _referencevalue;
        private bool _value;

        private void OnEnable()
        {
            _value = _referencevalue;
        }

        public bool Value { get => _value; set => this._value = value; }

        public void SetValue(bool value)
        {
            Value = value;
        }

        public void SetValue(BoolVariableSO value)
        {
            Value = value.Value;
        }

        public static BoolVariableSO NewBool(ScriptableObject so, string name)
        {
            BoolVariableSO newBool = ScriptableObject.CreateInstance<BoolVariableSO>();
            newBool.name = name;
            return newBool;
        }
    }
}