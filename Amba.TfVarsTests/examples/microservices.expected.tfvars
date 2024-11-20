microservices = {
  "auth-api" = {
    k8s = {
      namespace_name = "auth-api-dev"
      cpu_quota      = 1000
    }
    databases = [
      {
        name = "auth-api-db"
        type = "mysql"
      }
    ]
  }
  email_sender = {
    k8s = {
      namespace_name = "email-sender-dev"
      cpu_quota      = 1000
    }
    databases = [
      {
        name = "email-sender-db"
        type = "mysql"
      }
    ]
  }
  "ledger-api" = {
    k8s = {
      namespace_name = "ledger-api-dev"
      cpu_quota      = 1000
    }
    databases = [
      {
        name = "ledger-api-db"
        type = "mysql"
      }
    ]
  }
}