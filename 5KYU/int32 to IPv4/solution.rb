require 'ipaddr'

def int32_to_ip(int32)
  IPAddr.new(int32, Socket::AF_INET).to_s
end