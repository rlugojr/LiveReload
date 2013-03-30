﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace LiveReload
{
    public class ActionsFilesViewModel
    {
        private ObservableCollection<ActionGroup> groups = new ObservableCollection<ActionGroup>();

        public ActionsFilesViewModel() {
            groups.Add(new ActionGroup { Title = "stylesheets" });
            groups.Add(new ActionGroup { Title = "scripts" });
            groups.Add(new ActionGroup { Title = "html and templates" });
        }

        public ObservableCollection<ActionGroup> Groups {
            get {
                return groups;
            }
        }
    }

    public class ActionGroup
    {
        private ObservableCollection<ProjectAction> actions = new ObservableCollection<ProjectAction>();

        public string Title { get; set; }

        public ActionGroup() {
            actions.Add(new ProjectAction { Name = "compile sass" });
            actions.Add(new ProjectAction { Name = "compile less" });
            actions.Add(new ProjectAction { Name = "compile haml" });
        }

        public ObservableCollection<ProjectAction> Actions {
            get {
                return actions;
            }
        }
    }

    public class ProjectAction
    {
        private ObservableCollection<Rule> rules = new ObservableCollection<Rule>();

        public string Name { get; set; }

        public ProjectAction() {
            rules.Add(new Rule { Source = "foo/**/*.sass", Destination = "foo/**/*.css" });
            rules.Add(new Rule { Source = "bar/sass/*.sass", Destination = "bar/css/*.css" });
        }

        public ObservableCollection<Rule> Rules {
            get {
                return rules;
            }
        }
    }

    public class Rule
    {
        private ObservableCollection<RuleFile> files = new ObservableCollection<RuleFile>();

        public string Source { get; set; }
        public string Destination { get; set; }

        public Rule() {
            files.Add(new RuleFile { SourcePath = "foo/styles.sass", DestinationPath = "foo/styles.css" });
            files.Add(new RuleFile { SourcePath = "bar/sass/widgets.sass", DestinationPath = "bar/css/widgets.css" });
            files.Add(new RuleFile { SourcePath = "bar/sass/typography.sass", DestinationPath = "bar/css/typography.css" });
        }

        public ObservableCollection<RuleFile> Files {
            get {
                return files;
            }
        }
    }

    public class RuleFile
    {
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
    }
}
