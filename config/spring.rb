# Having issues with spring and our mongodb files in the tmp folder
# Spring.watch(
#   ".ruby-version",
#   ".rbenv-vars",
#   "tmp/restart.txt",
#   "tmp/caching-dev.txt"
# )

# module SpringWatcherListenIgnorer
#   def start
#     super
#     listener.ignore(/^tmp\/mongodb|^node_modules/)
#   end
# end
# Spring::Watcher::Listen.prepend SpringWatcherListenIgnorer
