A delegate is a variable type that encapsulates function implementations, similar to function pointers in C and C++. Delegates are object-oriented, type-safe, and secure. Commonly, delegates are used to define call-back functions. In this post, we are going to examine how to declare and use delegates in C#.

<!--more-->

<strong>DELEGATE DECLARATION</strong>

It is quite simple to declare a delegate. Similar to declarations of abstract methods in object-oriented programming, to declare a delegate, we need a delegate name (which is also the type of the constructed delegate), its method signature, and a return type.

<div class="highlight"><pre><span></span><span class="c1">// Declare a delegate type.</span>
<span class="k">public</span> <span class="k">delegate</span> <span class="kt">int</span> <span class="nf">MyDelegate</span> <span class="p">(</span><span class="kt">int</span> <span class="n">i</span><span class="p">,</span> <span class="kt">string</span> <span class="n">s</span><span class="p">);</span>
</pre></div>


In the example above, we declare a delegate named <strong>MyDelegate</strong> which is going to return an <strong>integer </strong>value and this type of delegate accepts an <strong>integer </strong>and a <strong>string </strong>as its parameters. Consequently, this delegate can be used as a reference to any functions that have that method signature. At this stage, we have not actually referenced the delegate to any functions.

<strong>DELEGATE USAGE</strong>

Firstly, we need to declare a function which needs to be referenced by our delegate. This function must satisfy two conditions: it has to have the same signature of our delegate and it must return the same type as the delegate decoration. That is, the function should have an <strong>integer </strong>as its return type and its parameters must consist of an <strong>integer </strong>and a <strong>string </strong>types.

<div class="highlight"><pre><span></span><span class="c1">// Function declaration.</span>
<span class="kt">int</span> <span class="nf">myFunction</span> <span class="p">(</span><span class="kt">int</span> <span class="n">index</span><span class="p">,</span> <span class="kt">string</span> <span class="k">value</span><span class="p">)</span> <span class="p">{</span>
	<span class="c1">//  Function implementation goes here.</span>
<span class="p">}</span>
</pre></div>

Ok, now we have a delegate and a concrete implementation of our function (named myFunction). What we need to do next is to link these two together.

<div class="highlight"><pre><span></span><span class="c1">// Delegate initiation.</span>
<span class="n">MyDelegate</span> <span class="n">f</span>  <span class="p">=</span> <span class="n">myFunction</span><span class="p">;</span>
</pre></div>

The statement above declare a variable named <strong>f</strong> of MyDelegate type. By declaring this, we telling the compile that <strong>f</strong> is capable of referencing a concrete implementation of a function. Then, we assign our function's definition above to <strong>f</strong>. <strong>f</strong> now refers to the implementation of <strong>MyFunction</strong>. Therefore, from now on, we can call and execute <strong>f</strong> in place of MyFunction.

<div class="highlight"><pre><span></span><span class="c1">// Call and execute delegate.</span>
<span class="kt">int</span> <span class="n">result</span>  <span class="p">=</span> <span class="n">f</span> <span class="p">(</span><span class="m">114</span><span class="p">,</span> <span class="s">&quot;my-value&quot;</span><span class="p">);</span>
</pre></div>

One of the advantages of using delegates is the capability of switching function implementations during runtime. For example, we have another function implementation called <strong>MyFunction2</strong>. During runtime, if we assign <strong>f</strong> to <strong>MyFunction2</strong>, the above statement will return a result based on <strong>MyFunction2 </strong>implementation.

<div class="highlight"><pre><span></span><span class="c1">// Switching delegate implementation.</span>
 <span class="n">f</span> <span class="p">=</span> <span class="n">myFunction2</span><span class="p">;</span>
 <span class="n">result</span> <span class="p">=</span> <span class="n">f</span><span class="p">(</span><span class="m">123</span><span class="p">,</span> <span class="s">&quot;another-value&quot;</span><span class="p">);</span>
</pre></div>

<strong>ANONYMOUS DELEGATES</strong>

This is a short-handed declaration of delegates. Instead of constructing a function implementation separately then assign it to the delegate reference, we can combine these steps into one single statement.

<div class="highlight"><pre><span></span><span class="c1">// Anonymous delegate declaration.</span>
<span class="n">MyDelegate</span> <span class="n">f</span> <span class="p">=</span> <span class="k">delegate</span> <span class="p">(</span><span class="kt">int</span> <span class="n">i</span><span class="p">,</span> <span class="kt">string</span> <span class="n">s</span><span class="p">)</span> <span class="p">{</span>
	<span class="c1">// Function implementation goes here.</span>
<span class="p">}</span>
</pre></div>

This statement achieves the same result as what we did in the previous section.

<strong>REFERENCES</strong>
<a href="https://www.lynda.com/C-tutorials/C-Delegates-Events-Lambdas/370499-2.html">Lynda.com - C#: Delegates, Events and Lambdas - by Joe Marini</a>
<a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/">Microsoft - Delegates (C# Programming Guide)</a>
<a href="https://www.tutorialspoint.com/csharp/csharp_delegates.htm">TutorialPoints - C# Delegates</a>
