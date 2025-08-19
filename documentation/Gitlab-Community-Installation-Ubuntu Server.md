 # Gitlab Community Edition
 
 ## Installation on Ubuntu 20.04 LTS

 ### SSH
 ssh to remote server first via powershell or git bash from windows machine. From linux machine use terminal instead. 
 
 Enter the following command:

 ```ssh rabbi@192.168.100.42```

### Update linux packages
Update ubuntu 20.04 packages with source with the following command. This will help linux os to sync with ubuntu package repository.

Enter the following command:

```sudo apt-get update```

### Postfix
Install postfix to setup smtp server. Enter the following command:

```sudo apt-get install -y postfix```

You should see the screen as the following screenshot. Configure it as the following screenshots.

![gitlab-postfix](/uploads/-/system/personal_snippet/2/959228712ac60f82b977e427efa69128/gitlab-postfix.PNG)

![gitlab-postfix02](/uploads/-/system/personal_snippet/2/e94d6105dc5adbbe77c5a65e57779240/gitlab-postfix02.PNG)

![gitlab-postfix03](/uploads/-/system/personal_snippet/2/70a16e2604807b07dc95a4e878bf5085/gitlab-postfix03.PNG)

### Install prerequisites
Need the following necessary packages for gitlab installation.
- curl
- openssh-server
- ca-certificates 
- tzdata 
- perl

Enter the following command:

```sudo apt-get install -y curl openssh-server ca-certificates tzdata perl```

### Install gitlab-ce
First download the gitlab-ce shell file to sync gitlab-ce package repository with the following command:

```curl -sS https://packages.gitlab.com/install/repositories/gitlab/gitlab-ce/script.deb.sh | sudo bash```

Then enter the following command to update new package repository with ubuntu package sources.

```sudo apt update```

After successfully updated, enter the following command to install gitlab-ce
 
```sudo apt install gitlab-ce```

Output should be the following snippet:
```
Reading package lists... Done
Building dependency tree
Reading state information... Done
The following NEW packages will be installed:
  gitlab-ce
0 upgraded, 1 newly installed, 0 to remove and 63 not upgraded.
Need to get 1,048 MB of archives.
After this operation, 2,913 MB of additional disk space will be used.
Get:1 https://packages.gitlab.com/gitlab/gitlab-ce/ubuntu focal/main amd64 gitlab-ce amd64 14.10.2-ce.0 [1,048 MB]
Fetched 1,048 MB in 33min 42s (518 kB/s)
Selecting previously unselected package gitlab-ce.
(Reading database ... 71958 files and directories currently installed.)
Preparing to unpack .../gitlab-ce_14.10.2-ce.0_amd64.deb ...
Unpacking gitlab-ce (14.10.2-ce.0) ...
Setting up gitlab-ce (14.10.2-ce.0) ...
It looks like GitLab has not been configured yet; skipping the upgrade script.

       *.                  *.
      ***                 ***
     *****               *****
    .******             *******
    ********            ********
   ,,,,,,,,,***********,,,,,,,,,
  ,,,,,,,,,,,*********,,,,,,,,,,,
  .,,,,,,,,,,,*******,,,,,,,,,,,,
      ,,,,,,,,,*****,,,,,,,,,.
         ,,,,,,,****,,,,,,
            .,,,***,,,,
                ,*,.



     _______ __  __          __
    / ____(_) /_/ /   ____ _/ /_
   / / __/ / __/ /   / __ `/ __ \
  / /_/ / / /_/ /___/ /_/ / /_/ /
  \____/_/\__/_____/\__,_/_.___/


Thank you for installing GitLab!
GitLab was unable to detect a valid hostname for your instance.
Please configure a URL for your GitLab instance by setting `external_url`
configuration in /etc/gitlab/gitlab.rb file.
Then, you can start your GitLab instance by running the following command:
  sudo gitlab-ctl reconfigure

For a comprehensive list of configuration options please see the Omnibus GitLab readme
https://gitlab.com/gitlab-org/omnibus-gitlab/blob/master/README.md

Help us improve the installation experience, let us know how we did with a 1 minute survey:
https://gitlab.fra1.qualtrics.com/jfe/form/SV_6kVqZANThUQ1bZb?installation=omnibus&release=14-10
```

#### Configure Gitlab-CE
Enter the following command to update configuration.

```sudo vim /etc/gitlab/gitlab.rb```

Update the following line by server host name or ip address.

```external_url 'http://gitlab.example.com'```

Then write the following command to reconfigure gitlab-ce

```sudo gitlab-ctl reconfigure```

If success then you should show the output like the below snippet:

```
Recipe: gitlab-kas::enable
  * runit_service[gitlab-kas] action restart (up to date)
Recipe: gitlab::gitlab-workhorse
  * runit_service[gitlab-workhorse] action restart (up to date)
Recipe: monitoring::node-exporter
  * runit_service[node-exporter] action restart (up to date)
Recipe: monitoring::gitlab-exporter
  * runit_service[gitlab-exporter] action restart (up to date)
Recipe: monitoring::redis-exporter
  * runit_service[redis-exporter] action restart (up to date)
Recipe: monitoring::prometheus
  * runit_service[prometheus] action restart (up to date)
  * execute[reload prometheus] action run
    - execute /opt/gitlab/bin/gitlab-ctl hup prometheus
Recipe: monitoring::alertmanager
  * runit_service[alertmanager] action restart (up to date)
Recipe: monitoring::postgres-exporter
  * runit_service[postgres-exporter] action restart (up to date)
Recipe: monitoring::grafana
  * runit_service[grafana] action restart (up to date)

Running handlers:
Running handlers complete
Chef Infra Client finished, 602/1614 resources updated in 04 minutes 32 seconds

Notes:
Default admin account has been configured with following details:
Username: root
Password: You didn't opt-in to print initial root password to STDOUT.
Password stored to /etc/gitlab/initial_root_password. This file will be cleaned up in first reconfigure run after 24 hours.

NOTE: Because these credentials might be present in your log files in plain text, it is highly recommended to reset the password following https://docs.gitlab.com/ee/security/reset_user_password.html#reset-your-root-password.

gitlab Reconfigured!
```

To check gitlab-ce status enter the following command:

```sudo gitlab-ctl status```

You should show the output as the following snippet.

```
run: alertmanager: (pid 17203) 323s; run: log: (pid 16907) 399s
run: gitaly: (pid 17226) 323s; run: log: (pid 15987) 557s
run: gitlab-exporter: (pid 17173) 325s; run: log: (pid 16669) 418s
run: gitlab-kas: (pid 17131) 327s; run: log: (pid 16422) 534s
run: gitlab-workhorse: (pid 17146) 327s; run: log: (pid 16575) 437s
run: grafana: (pid 17238) 322s; run: log: (pid 17064) 349s
run: logrotate: (pid 15771) 572s; run: log: (pid 15895) 569s
run: nginx: (pid 16590) 433s; run: log: (pid 16608) 430s
run: node-exporter: (pid 17159) 326s; run: log: (pid 16655) 424s
run: postgres-exporter: (pid 17217) 323s; run: log: (pid 16954) 394s
run: postgresql: (pid 16141) 549s; run: log: (pid 16174) 545s
run: prometheus: (pid 17182) 325s; run: log: (pid 16800) 408s
run: puma: (pid 16489) 451s; run: log: (pid 16496) 450s
run: redis: (pid 15920) 566s; run: log: (pid 15934) 563s
run: redis-exporter: (pid 17175) 325s; run: log: (pid 16687) 412s
run: sidekiq: (pid 16506) 445s; run: log: (pid 16522) 442s
```

Then visit the site by hostname or ip address. You should show the following screen.

[TODO]

### Gitlab Management
Now login with user/password to system. 

For the first time root user name is root and random password is stored in the following directory and is available for 24 hours only.

```/etc/gitlab/initial_root_password```

Write the following command to show the file.

```sudo nano /etc/gitlab/initial_root_password```

You should show the output as the following snippet.

```
# WARNING: This value is valid only in the following conditions
#          1. If provided manually (either via `GITLAB_ROOT_PASSWORD` environment variable or via `gitlab_rails['initial_root_password']` setting in `gitlab.rb`, it was provided before database was seeded for the first time (usually, the first reconfigure run).
#          2. Password hasn't been changed manually, either via UI or via command line.
#
#          If the password shown here doesn't work, you must reset the admin password following https://docs.gitlab.com/ee/security/reset_user_password.html#reset-your-root-password.

Password: Qt+UDU6IhJWXTB8omA2sAvd+gMlOp78wHMbVUSYalzg=

# NOTE: This file will be automatically deleted in the first reconfigure run after 24 hours.

```

Copy the password and login. You should show the dashboard as the following window. [TODO]

Go to the Profile -> Preferences -> Password and update root password.

That's it, you're done!

## References:
- https://about.gitlab.com/install/?version=ce#ubuntu
- https://computingforgeeks.com/how-to-install-gitlab-ce-on-ubuntu-linux/
- https://docs.gitlab.com/omnibus/settings/smtp.html
- https://packages.gitlab.com/gitlab/gitlab-ce?page=1
