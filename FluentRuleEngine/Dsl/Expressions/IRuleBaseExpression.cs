﻿using System;
using FluentRuleEngine.Dsl.Builders;

namespace FluentRuleEngine.Dsl.Expressions
{
	public interface IRuleBaseExpression<T>
	{
		RuleExpression<T> AddRule(string name);
		void AddRuleSet(Action<IRuleSetExpression<T>> ruleSetExpressionAction);
		void AddRuleSet<TRuleSet>() where TRuleSet : RuleSetBuilder<T>;
	}
}