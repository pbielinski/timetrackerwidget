namespace TimeTrackerWidget.Utils
{
    /// <summary>
    /// Singleton
    /// </summary>
    /// <typeparam name="T">class</typeparam>
    public class SingletonGenericProvider<T> where T : new()
    {
		#region Classes (1)
		class SingletonCreator
        {
			#region Static Fields (1)
			internal static readonly T instance = new T();
			#endregion

			#region Constructors (1)
			static SingletonCreator() { }
			#endregion
        }
		#endregion

		#region Properties (1)
		/// <summary>
        /// Gets the instance.
        /// </summary>
		public static T Instance
        {
            get { return SingletonCreator.instance; }
        }
		#endregion

		#region Constructors (1)
		public SingletonGenericProvider() { }
		#endregion
    }
}
