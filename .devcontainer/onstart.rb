#!/usr/bin/env ruby
require 'fileutils'

# path to your application root.
APP_ROOT = File.expand_path('..', __dir__)

def system!(*args)
  system(*args) || abort("\n== Command #{args} failed ==")
end

FileUtils.chdir APP_ROOT do
  puts '== Fixing Ownership =='
  system 'sudo chown -R vscode:vscode .'

  system! 'bin/setup'

  puts '== Start Spring Server =='
  system 'spring server'
end
