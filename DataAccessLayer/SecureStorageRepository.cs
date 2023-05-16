namespace DataAccessLayer
{
    public static class SecureStorageRepository
    {
        public static async Task<string?> GetValueAsync(string key)
        {
            return await Microsoft.Maui.Storage.SecureStorage.Default.GetAsync(key);
        }

        public static async Task SetValueAsync(string key, string value)
        {
            await Microsoft.Maui.Storage.SecureStorage.Default.SetAsync(key, value);
        }

        public static async Task<bool> RemoveValueAsync(string key)
        {
            return await Task.FromResult(Microsoft.Maui.Storage.SecureStorage.Default.Remove(key));
        }

        public static async Task RemoveAllValuesAsync()
        {
            await Task.Run(Microsoft.Maui.Storage.SecureStorage.Default.RemoveAll);
        }
    }
}