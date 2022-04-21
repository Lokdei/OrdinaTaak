
using OrdinaTaak.Readers;

namespace OrdinaTaak.Auth
{
    public sealed class RoleValidation
    {
        // this is our mapping of roles to actions
        private readonly Dictionary<Type, List<IReadPermission>> _roleMap = new();
        private readonly static RoleValidation instance = new();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static RoleValidation() { }

        private RoleValidation()
        {
            AssignActionToRole<ReadTextRole>(new OReadTextFile());
            AssignActionToRole<ReadXMLRole>(new OReadXMLFile());
        }

        public static RoleValidation Instance
        {
            get
            {
                return instance;
            }
        }


        internal void AssignActionToRole<T>(IReadPermission action)
        {
            if (action == null) throw new NullReferenceException(nameof(action));

            var key = typeof(T);
            if (_roleMap.ContainsKey(key))
            {
                _roleMap[key].Add(action);
            }
            else
            {
                List<IReadPermission> actions = new();
                actions.Add(action);
                _roleMap[key] = actions;
            }
        }

        // Nice generic function for ease of use
        internal List<IReadPermission> GetActions<T>() where T : IRole
        {
            foreach (var pair in _roleMap)
            {
                if (typeof(T).IsAssignableFrom(pair.Key.GetType()))
                    return pair.Value;
            }

            return new();
        }

        internal List<IReadPermission> GetActions(Type type)
        {
            foreach (var pair in _roleMap)
            {
                var taqn = type.FullName;
                var paqn = pair.Key.ToString();
                if (string.Equals(taqn, paqn)) return pair.Value;
                // if (type.IsAssignableFrom(pair.Key.GetType())) return pair.Value;
            }

            return new();
        }
    }
}

