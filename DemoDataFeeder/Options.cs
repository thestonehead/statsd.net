﻿using CommandLine;
using CommandLine.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataFeeder
{
  class Options
  {
    [Option('h', "host", Required = false, DefaultValue = "localhost", HelpText="Statsd host name")]
    public string Host { get; set; }
    [Option('p', "port", Required = false, DefaultValue = 12000, HelpText="Statsd listen port")]
    public int Port { get; set; }
    [Option( 'd', "delay", Required = false, DefaultValue = 500, HelpText = "Delay between sends in Milliseconds." )]
    public int Delay { get; set; }
    [Option( 't', "threads", Required = false, DefaultValue = 1, HelpText = "Number of parallel threads to start." )]
    public int Threads { get; set; }

    [HelpOption]
    public string GetUsage()
    {
      return HelpText.AutoBuild(this,
        current => HelpText.DefaultParsingErrorsHandler(this, current));
    }
  }
}