using System.Text;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.QueryParsers.Classic;
using Lucene.Net.Util;


Console.OutputEncoding=Encoding.UTF8;
var std= new StandardAnalyzer(LuceneVersion.LUCENE_48, StandardAnalyzer.STOP_WORDS_SET);
Console.Write("A");
var qp = new MultiFieldQueryParser(LuceneVersion.LUCENE_48, new[] {"test"}, std);
Console.Write("B");

// run: `dotnet run`
// outputs: AB
