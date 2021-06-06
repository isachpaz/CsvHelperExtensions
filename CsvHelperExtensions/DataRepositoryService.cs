using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using Vouzamo.Specification.Interfaces;

namespace CsvHelperExtensions
{
    public class DataRepositoryService<T, TM> where TM : ClassMap<T>
    {
        protected readonly List<T> _items = new List<T>();

        private DataRepositoryService()
        {
        }

        public DataRepositoryService(DataRepositoryService<T, TM> service) => this._items.AddRange((IEnumerable<T>)service._items);

        public DataRepositoryService(List<T> items) => this._items = items;
       
        public static DataRepositoryService<T, TM> FromCSVFile(
          string csvFileName)
        {
            DataRepositoryService<T, TM> DataRepositoryService = new DataRepositoryService<T, TM>();
            return !File.Exists(csvFileName) ? DataRepositoryService : DataRepositoryService<T, TM>.FromCSV(File.ReadAllText(csvFileName));
        }

        public static DataRepositoryService<T, TM> FromCSV(string csvData, CsvConfiguration csvConfiguration = null)
        {
            DataRepositoryService<T, TM> dataRepositoryService = new DataRepositoryService<T, TM>();
            if (string.IsNullOrEmpty(csvData))
                return dataRepositoryService;
            dataRepositoryService.AddRange(DataRepositoryService<T, TM>.GetItemsFromString(csvData, csvConfiguration));
            return dataRepositoryService;
        }

        private static IEnumerable<T> GetItemsFromString(string data, CsvConfiguration csvConfiguration)
        {
            if (csvConfiguration != null)
            {
                csvConfiguration.HeaderValidated = null;
                csvConfiguration.MissingFieldFound = null;
            }
            else
            {
                csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HeaderValidated = (HeaderValidated)null,
                    MissingFieldFound = (MissingFieldFound)null
                };
            }

            byte[] byteArray = Encoding.UTF8.GetBytes(data);
            MemoryStream stream = new MemoryStream(byteArray);

            using (StreamReader reader = new StreamReader((Stream)stream))
            {
                using (CsvReader csv = new CsvReader((TextReader)reader, csvConfiguration))
                {
                    csv.Context.RegisterClassMap<TM>();
                    IEnumerable<T> records = csv.GetRecords<T>();
                    foreach (T obj in records)
                    {
                        T item = obj;
                        yield return item;
                        item = default(T);
                    }
                    records = (IEnumerable<T>)null;
                }
            }
            stream.Dispose();
            stream = null;
        }

        protected void AddRange(IEnumerable<T> items) => this._items.AddRange(items);

        public virtual IEnumerable<T> GetAll() => (IEnumerable<T>)this._items;

        public virtual IEnumerable<T> Get(ISpecification<T> spec)
        {
            foreach (T obj in this._items)
            {
                T item = obj;
                if (spec.IsSatisfiedBy(item))
                    yield return item;
                item = default(T);
            }
        }

        public override string ToString() => string.Format("ConfigItem: {0}", (object)this._items.Count);

    }
}
