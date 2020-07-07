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

  puts '== Installing dependencies =='
  system! 'gem install bundler --conservative'
  system('bundle check') || system!('bundle install')

  # Install JavaScript dependencies
  system('bin/yarn')

  puts '== Removing old logs and tempfiles =='
  system 'bin/rails tmp:clear'
end
